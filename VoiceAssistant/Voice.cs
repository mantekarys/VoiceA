using System;
using System.Threading.Tasks;
using System.IO;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using WindowsInput;
using WindowsInput.Native;
using System.Runtime.InteropServices;
using ShortCuts;
using Gma.System.MouseKeyHook;
using static VoiceAssistant.Overlay;
using System.Collections.Generic;

namespace VoiceAssistant
{
	public class Voice
	{
		String[] commandFile = CommandAdjustment();
		String[] countryFile = File.ReadAllLines(@"Countries.txt"); //file with country names
		String[] locationFile = File.ReadAllLines(Constants.LocationFile); //file with locations' names
		String[] musicFile = File.ReadAllLines(@"Music.txt");//file with song names...will be usefull with spotify
		String[] timeFile = File.ReadAllLines(@"Time.txt");
		SpeechSynthesizer speechSynth = new SpeechSynthesizer();
		List<Alarm> alarms;
		private static String[] CommandAdjustment()
		{
			String[] temp = File.ReadAllLines(@"Commands.txt");
			String[] commnadlines = new String[temp.Length];
			for(int i =0; i< temp.Length; i++)
			{
				String[] parts = temp[i].Split(';');
				commnadlines[i] = parts[0];
			}
			return commnadlines;
		}

		Choices commandList = new Choices();
		SpeechRecognitionEngine speechRecognition = new SpeechRecognitionEngine();

        internal void AddAlarms(List<Alarm> alarms)
        {
			this.alarms = alarms;
        }

        Boolean wake = true;
		Boolean search = false;
		Boolean open = false;
		Boolean remove = false;
		Boolean timer = false;
		Boolean time = false;
		int distance = 0;
		String location1, location2;
		int timeSeconds = 0;
		int timeUnknown = 0;
		Boolean soundEquals = false;
		Boolean weather = false;
		Boolean calendarList = false;
		Boolean calendarRemove = false;
		CalendarForm form;
		DictationGrammar dictation = new DictationGrammar();

		private IKeyboardMouseEvents GlobalHook;

		private VoiceRecorder voiceRecorder;

		//public delegate void EventDelegate(object source, OverlayEventArg e);
		public event EventHandler<OverlayEventArg> ChangeImage; // event and delegate declaration
		public Voice()
		{
			voiceRecorder = new VoiceRecorder(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Recordings"));

			commandList.Add(commandFile);
			commandList.Add(timeFile);
			Grammar commands = new Grammar(new GrammarBuilder(commandList));//makes an object that stores all the words that will be listened to
			try
			{
				speechRecognition.RequestRecognizerUpdate();
				speechRecognition.LoadGrammar(commands);//adds which words (grammar object) to listen to
				speechRecognition.SpeechRecognized += rec_SpeechRecognized;
				speechRecognition.SetInputToDefaultAudioDevice();//selects the microphone
				speechRecognition.RecognizeAsync(RecognizeMode.Multiple);//makes the listening asynchonous

				GlobalHook = Hook.GlobalEvents();
				GlobalHook.KeyDown += ActivationKey.GlobalHook_KeyDown;
				GlobalHook.KeyUp += ActivationKey.GlobalHook_KeyUp;
				GlobalHook.MouseDown += ActivationKey.GlobalHook_MouseKeyDown;
				GlobalHook.MouseUp += ActivationKey.GlobalHook_MouseKeyUp;
			}
			catch
			{
				return;
			}
			//custom speech settings
			speechSynth.SelectVoiceByHints(VoiceGender.Female);
		}

		public void say(String text)//method that says the text
		{
			speechSynth.SpeakAsync(text);
		}

		private void minimize()//minimizes any active window
		{
			SendKeys.SendWait("% ");
			Task.Delay(200).Wait();
			SendKeys.SendWait("n");
		}

		private void haveOneLoaded(String[] wordArray)
		{
			commandList = new Choices();
			commandList.Add(wordArray);
			Grammar commands = new Grammar(new GrammarBuilder(commandList));
			speechRecognition.UnloadAllGrammars();
			speechRecognition.LoadGrammar(commands);
		}

		[DllImport("user32.dll")]
		public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);//used to generate play, previous , next button presses

		private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)//method in which we decide what happens when a command is recognized 
		{
			String result = e.Result.Text;//the text that was recognized
			bool flag = false;

			if (ActivationKey.IsClicked())
			{
				flag = true;
				OnChangeImage(flag);
			}
			if (result == "wake")
			{
				wake = !wake;
			}
			if (wake && flag)
			{
				switch (result)
				{
					case "next":
						keybd_event(0xB0, 0, 1, IntPtr.Zero);
						break;
					case "previous":
						keybd_event(0xB1, 0, 1, IntPtr.Zero);
						break;
					case "dictation":
						speechRecognition.LoadGrammar(dictation);
						break;
					case "finish":
						try
						{
							speechRecognition.UnloadGrammar(dictation);
						}
						catch
						{

						}
						break;
					case "mute":
						CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
						if (defaultPlaybackDevice.IsMuted) defaultPlaybackDevice.Mute(false);
						else defaultPlaybackDevice.Mute(true);
						break;
					case "sound up":
						defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
						var currentSound = defaultPlaybackDevice.Volume;
                        Console.WriteLine("sound before: " + defaultPlaybackDevice.Volume);
						if (currentSound <= 90) defaultPlaybackDevice.Volume = currentSound + 10;
						else defaultPlaybackDevice.Volume = 100;
						Console.WriteLine("sound after: " + defaultPlaybackDevice.Volume);
						break;
					case "sound down":
						defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
						currentSound = defaultPlaybackDevice.Volume;
						Console.WriteLine("sound before: " + defaultPlaybackDevice.Volume);
						if (currentSound >= 10) defaultPlaybackDevice.Volume = currentSound - 10;
						else defaultPlaybackDevice.Volume = 0;
						Console.WriteLine("sound after: " + defaultPlaybackDevice.Volume);
						break;
					case "write":
						var simu = new InputSimulator();
						simu.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_H);
						break;
					case "test":
						keybd_event(0xB3, 0, 1, IntPtr.Zero);
						break;
					case "minimize":
						minimize();
						break;
					case "stopWatch":
						Stopwatch s = new Stopwatch();
						s.Show();
						break;
					case "translate":
						say(MantasOnline.Translate());
						break;
					case "definition":
						say(MantasOnline.Definition());
						break;
					case "converter":
						ConverterForm c = new ConverterForm();
						c.Show();
						break;
					case "alarm":
						AlarmsForm al = new AlarmsForm(alarms);
						al.Show();
						break;
					case "notes": //for calling notes
						TextBoxPopup notes = new TextBoxPopup();
						notes.Show();
						break;
					default:
						break;

				}
				if (search)//does Viliau's time function and starts listening to commands and music names again
				{
					say(Time.getTimeInCity(result));
					search = false;
					haveOneLoaded(commandFile);
				}
				else if (result == "search")//starts listening only to country names....used to improve correct word recognition
				{
					search = true;
					haveOneLoaded(countryFile);
				}
				else if (open)//opens a shortcut
				{
					Shortcut.Open(result, Constants.ShortcutsFolder);
					open = false;
					haveOneLoaded(commandFile);
				}
				else if (result == "open")//starts listening to file names in Shortcut
				{
					open = true;
					String[] files = TaskUtils.GetFileNames(Constants.ShortcutsFolder);
					haveOneLoaded(files);
				}
				else if (remove)//removes a shortcut
				{
					Shortcut.Remove(result, Constants.ShortcutsFolder);
					remove = false;
					haveOneLoaded(commandFile);
				}
				else if (result == "remove")//starts listening to file names in Shortcut
				{
					remove = true;
					String[] files = TaskUtils.GetFileNames(Constants.ShortcutsFolder);
					haveOneLoaded(files);
				}
				else if (result == "play music" || result == "pause")//generates play button press
				{
					keybd_event(0xB3, 0, 1, IntPtr.Zero);
				}
				if (soundEquals)
				{
					CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
					defaultPlaybackDevice.Volume = int.Parse(result);
					soundEquals = false;
				}
				else if (result == "sound equals")
				{
					soundEquals = true;
				}
				else if (weather)
				{
					Task.Factory.StartNew(() =>
					{
						weather = false;
						haveOneLoaded(commandFile);
						Application.Run(new weather_ui(result));
					});
				}
				else if (result == "weather")
				{
					weather = true;
					haveOneLoaded(countryFile);
				}
				else if (distance == 2)
				{
					Task.Factory.StartNew(() =>
					{
						haveOneLoaded(commandFile);
						location2 = e.Result.Text;
						distance = 0;

						int calcDist = LocationUtils.GetDistance(location1, location2);
						if (calcDist >= 0)
						{
                            Console.WriteLine($"The distance between { location1 } and { location2 } is { calcDist } kilometers.");
							say($"The distance between { location1 } and { location2 } is { calcDist } kilometers.");
						}
						else
						{
							if (calcDist == -1)
                            {
                                Console.WriteLine($"Location \"{ location1 }\" not found.");
								say($"Location \"{ location1 }\" not found.");
							}
							else if (calcDist == -2)
                            {
                                Console.WriteLine($"Location \"{ location2 }\" not found.");
								say($"Location \"{ location2 }\" not found.");
							}

                            else
                            {
                                Console.WriteLine($"Cloudn't calculate distance.");
								say($"Cloudn't calculate distance.");
							}
						}
					});
				}
				else if (distance == 1)
				{
					Task.Factory.StartNew(() =>
					{
						location1 = e.Result.Text;
						distance = 2;
					});
				}
				else if (result == "distance")
				{
					distance = 1;
					haveOneLoaded(locationFile);
				}
				else if (result == "recorder")
				{
					if (!voiceRecorder.IsRecording)
                    {
						say("Recording started.");
                        Console.WriteLine("Recording started.");
					}
					voiceRecorder.Start();
				}
				else if (timer)
				{
					time = true;
					if(result == "hour")
					{
						if (timeUnknown >= 24)
							timeUnknown = 23;
						timeSeconds += timeUnknown * 3600;
						timeUnknown = 0;
					}

					else if (result == "minute")
					{
						if (timeUnknown >= 60)
							timeUnknown = 59;
						timeSeconds += timeUnknown * 60;
						timeUnknown = 0;
					}

					else if (result == "second")
					{
						if (timeUnknown >= 60)
							timeUnknown = 59;
						timeSeconds += timeUnknown;
						timeUnknown = 0;
					}
				}
				if (time)
				{
					int add = 0;
					int.TryParse(result, out add);
					timeUnknown += add;
					int x = 5;
				}
				if (result == "set timer")
				{
					timer = true;
				}
				else if (result == "show timer")
				{
					timer = true;
					TimerForm t = new TimerForm();
					t.Show();
				}
				if (result == "end")
				{
					timer = false;
					time = false;
					if (timeSeconds != 0)
					{
						TimerForm t = new TimerForm(timeSeconds);
						t.Show();
						timeSeconds = 0;
					}
				}
				else if (calendarList)
				{
					Task.Factory.StartNew(() =>
					{
						calendarList = false;
						form = new CalendarForm();
						int num;
						if(int.TryParse(result, out num))
                        {
							form.List(num);
							Application.Run(form);
						}
                        else
                        {
							say("You had to say a number of how many");
                        }
					});
				}
				else if (result == "calendarList")
				{
					calendarList = true;
				}
				else if (result == "calendarAdd")
				{
					Task.Factory.StartNew(() =>
					{
						//var form = new CalendarForm();
						var addForm = new CalendarAdd();
						Application.Run(addForm);
					});
				}
				else if (calendarRemove)
				{
					Task.Factory.StartNew(() =>
					{
						if (form != null)
                        {
							calendarRemove = false;
							int num;
							if (int.TryParse(result, out num))
							{
								say(form.Remove(num-1));
								//Application.Run(form);
							}
							else
							{
                                Console.WriteLine("You had to say a number of which event to remove");
								say("You had to say a number of which event to remove");
							}
						}
                        else
                        {
							Console.WriteLine("First use CalendarList");
							say("First use CalendarList");
                        }
					});
				}
				else if (result == "calendarRemove")
				{
					calendarRemove = true;
				}
				say(result);//repeats what you said
			}
			Console.WriteLine("You said: " + e.Result.Text);
		}

		protected virtual void OnChangeImage(bool check) //call to overlay for image change
		{
			if (ChangeImage != null)
			{
				ChangeImage(this, new OverlayEventArg() {active = check });
			}
		}

	}
}
