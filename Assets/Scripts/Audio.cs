using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Unity Audio Module
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    // Class
    // 1、AudioClip：A container for audio data.
    public AudioClip AudioClip;

    // 2、AudioSource：A representation of audio sources in 3D.
    // Assign an AudioSource to a GameObject and attach an Audio Clip in the Audio Source. Attach this script to the GameObject.
    public AudioSource AudioSource;

    // 3、AudioListener：Representation of a listener in 3D space.
    public AudioListener AudioListener;

    // 4、AudioMixer：his is a singleton representing a specific audio mixer asset in the project.
    public AudioMixer AudioMixer;

    // 5、AudioMixerGroup：Object representing a group in the mixer.
    public AudioMixerGroup AudioMixerGroup;

    // 6、AudioMixerSnapshot：Object representing a snapshot in the mixer.
    public AudioMixerSnapshot AudioMixerSnapshot;

    // 7、AudioRenderer：Allow recording the main output of the game or specific groups in the AudioMixer.
    public AudioRenderer AudioRenderer;

    // 8、AudioSettings：Controls the global audio settings from script.
    public AudioSettings AudioSettings;

    // 9、Microphone：Use this class to record to an AudioClip using a connected microphone.
    public Microphone Microphone;

    // 10、AudioChorusFilter：The Audio Chorus Filter takes an Audio Clip and processes it creating a chorus effect.
    public AudioChorusFilter AudioChorusFilter;

    // 11、AudioDistortionFilter：The Audio Distortion Filter distorts the sound from an AudioSource or sounds reaching the AudioListener.
    public AudioDistortionFilter AudioDistortionFilterF;

    // 12、AudioEchoFilter：The Audio Echo Filter repeats a sound after a given Delay, attenuating the repetitions based on the Decay Ratio.
    public AudioEchoFilter AudioEchoFilter;

    // 13、AudioHighPassFilter：The Audio High Pass Filter passes high frequencies of an AudioSource, and cuts off signals with frequencies lower than the Cutoff Frequency.
    public AudioHighPassFilter AudioHighPassFilter;

    // 14、AudioLowPassFilter：The Audio Low Pass Filter passes low frequencies of an AudioSource or all sounds reaching an AudioListener, while removing frequencies higher than the Cutoff Frequency.
    public AudioLowPassFilter AudioLowPassFilter;

    // 15、AudioReverbFilter：The Audio Reverb Filter takes an Audio Clip and distorts it to create a custom reverb effect.
    public AudioReverbFilter AudioReverbFilter;

    // 16、AudioReverbZone：Reverb Zones are used when you want to create location based ambient effects in the Scene.
    public AudioReverbZone AudioReverbZone;

    // 17、WebCamTexture：WebCam Textures are textures onto which the live video input is rendered.
    public WebCamTexture WebCamTexture;


    // Structs
    // 1、AudioClipPlayable：An implementation of IPlayable that controls an AudioClip.
    public AudioClipPlayable AudioClipPlayable;

    // 2、AudioConfiguration：Specifies the current properties or desired properties to be set for the audio system.
    public AudioConfiguration AudioConfiguration;

    // 3、AudioMixerPlayable：An implementation of IPlayable that controls an audio mixer.
    public AudioMixerPlayable AudioMixerPlayable;

    // 4、AudioPlayableOutput：A IPlayableOutput implementation that will be used to play audio.
    public AudioPlayableOutput AudioPlayableOutput;

    // 5、WebCamDevice：A structure describing the webcam device.
    public WebCamDevice WebCamDevice;

    
    // Enumerations
    // 1、AudioClipLoadType：Determines how the audio clip is loaded in.
    public AudioClipLoadType AudioClipLoadType;

    // 2、AudioCompressionFormat：An enum containing different compression types.
    public AudioCompressionFormat AudioCompressionFormat;

    // 3、AudioDataLoadState：Value describing the current load state of the audio data associated with an AudioClip.
    public AudioDataLoadState AudioDataLoadState;

    // 4、AudioMixerUpdateMode：The mode in which an AudioMixer should update its time.
    public AudioMixerUpdateMode AudioMixerUpdateMode;

    // 5、AudioReverbPreset：Reverb presets used by the Reverb Zone class and the audio reverb filter.
    public AudioReverbPreset AudioReverbPreset;

    // 6、AudioRolloffMode：Rolloff modes that a 3D sound can have in an audio source.
    public AudioRolloffMode AudioRolloffMode;

    // 7、AudioSourceCurveType：This defines the curve type of the different custom curves that can be queried and set within the AudioSource.
    public AudioSourceCurveType AudioSourceCurveType;

    // 8、AudioSpeakerMode：These are speaker types defined for use with AudioSettings.speakerMode.
    public AudioSpeakerMode AudioSpeakerMode;

    // 9、AudioVelocityUpdateMode：Describes when an AudioSource or AudioListener is updated.
    public AudioVelocityUpdateMode AudioVelocityUpdateMode;

    // 10、FFTWindow：Spectrum analysis windowing types.
    public FFTWindow FFTWindow;

    // 11、GamepadSpeakerOutputType：Gamepad audio output types.
    public GamepadSpeakerOutputType GamepadSpeakerOutputType;

    // 12、WebCamKind：Enum representing the different types of web camera device.
    public WebCamKind WebCamKind;

}
