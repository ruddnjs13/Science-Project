using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public enum Sfx
{
    MoveSound
}
public enum Bgm
{
    Bgm2
}


public class SoundManager : MonoBehaviour
{
    [SerializeField] private int _channelCount;

    [SerializeField] private AudioClip[] _sfxList;
    [SerializeField] private float _sfxVolume;
    private AudioSource[] _sfxPlayers;
    private int channelIndex;

    [SerializeField] private AudioClip[] _bgmList;
    [SerializeField] private float _bgmVolume;
    private AudioSource _bgmPlayer;

    private Dictionary<Sfx, AudioClip> sfxDic = new Dictionary<Sfx, AudioClip>();
    private Dictionary<Bgm, AudioClip> bgmDic = new Dictionary<Bgm, AudioClip>();

    public static SoundManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Initialize();
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        PlayBgm(Bgm.Bgm2);
    }

    private void Update()
    {
        _bgmPlayer.volume = _bgmVolume;
        
    }

    public float BgmVolue
    {
        get
        {
            return _bgmVolume;
        }
        set
        {
            _bgmVolume = value;
        }
    } 
    public float SfxVolue
    {
        get
        {
            return _sfxVolume;
        }
        set
        {
            _sfxVolume = value;
        }
    }

    private void Initialize()
    {

        //µñ¼î³ë¸®¿¡ ³Ö¾î
        foreach(AudioClip clip in _sfxList)
        {
            sfxDic.Add(Enum.Parse<Sfx>(clip.name), clip);
        } 
        foreach(AudioClip clip in _bgmList)
        {
            bgmDic.Add((Bgm)Enum.Parse(typeof(Bgm),clip.name), clip);
        }

        GameObject bgmobj = new GameObject("BgmPlayer");
        bgmobj.transform.parent = transform;
        _bgmPlayer =  bgmobj.AddComponent<AudioSource>();
        _bgmPlayer.volume = _bgmVolume;
        _bgmPlayer.loop = true;
        _bgmPlayer.playOnAwake = false;

        GameObject sfxobj = new GameObject("SfxPlayer");
        sfxobj.transform.parent = transform;
        _sfxPlayers = new AudioSource[_channelCount];
        for (int i = 0; i< _channelCount; i++)
        {
            _sfxPlayers[i] = sfxobj.AddComponent<AudioSource>();
            _sfxPlayers[i].playOnAwake = false;
            _sfxPlayers[i].volume = _sfxVolume;
        }
    }

    public void PlaySfx(Sfx sfx)
    {
        for (int i = 0; i < _sfxPlayers.Length; i++)
        {
            int loopIndex = (i + channelIndex) % _sfxPlayers.Length;
            if (_sfxPlayers[loopIndex].isPlaying)
            {
                continue;
            }
            channelIndex = loopIndex;
            _sfxPlayers[loopIndex].clip = _sfxList[(int)sfx];
            _sfxPlayers[loopIndex].Play();
            break;
        }
    }


    public void PlayBgm(Bgm bgm)
    {
        _bgmPlayer.clip = bgmDic[bgm];
        _bgmPlayer.Play();
    }
}
