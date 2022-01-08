using UnityEngine;

namespace Command
{
    public class InputHandler : MonoBehaviour
    {
        private Invoker _invoker;
        private bool _isReplaying;
        private bool _isRecording;
        private BikeController3 _bikeController;
        private Command _buttonA, _buttonD, _buttonW;

        private int numberCommand;
        // Start is called before the first frame update
        void Start()
        {
            _invoker = gameObject.AddComponent<Invoker>();
            _bikeController = FindObjectOfType<BikeController3>();
            _buttonA = new TurnLeft(_bikeController);
            _buttonD = new TurnRight(_bikeController);
            _buttonW = new ToggleTurbo(_bikeController);
            numberCommand = _invoker.CounterRecorded();
            Debug.Log("numberCommand: " + numberCommand);
        }

        // Update is called once per frame
        void Update()
        {
            if (!_isReplaying && _isRecording)
            {
                if (Input.GetKeyUp(KeyCode.A))
                    _invoker.ExecuteCommand(_buttonA);

                if (Input.GetKeyUp(KeyCode.D))
                    _invoker.ExecuteCommand(_buttonD);

                if (Input.GetKeyUp(KeyCode.W))
                    _invoker.ExecuteCommand(_buttonW);
                  
            }


        }

        void OnGUI()
        {
            if (!_isRecording)
            {
                numberCommand = _invoker.CounterRecorded();
                
                if (GUILayout.Button("Start Recording"))
                {
                    _bikeController.ResetPosition();
                    _isReplaying = false;
                    _isRecording = true;
                    _invoker.Record();
                }
                if (numberCommand > 0)
                {
                    if (GUILayout.Button("Start Replay"))
                    {
                        _bikeController.ResetPosition();
                        _isRecording = false;
                        _isReplaying = true;
                        _invoker.Replay();
                    }
                }

            }
            else
            {
                if (GUILayout.Button("Stop Recording"))
                {
                    _bikeController.ResetPosition();
                    _isRecording = false;
                }

            }
        }
    }
}

