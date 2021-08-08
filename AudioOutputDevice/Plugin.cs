﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using IPA;
using IPA.Config;
using IPA.Config.Stores;
using UnityEngine.SceneManagement;
using UnityEngine;
using IPALogger = IPA.Logging.Logger;
using BeatSaberMarkupLanguage.Settings;
using SiraUtil.Zenject;

namespace AudioOutputDevice
{

	[Plugin(RuntimeOptions.SingleStartInit)]
	public class Plugin
	{
		internal static Plugin Instance { get; private set; }
		internal static IPALogger Log { get; private set; }

		[Init]
		public void Init(IPALogger logger, Zenjector zenjector) {
			Instance = this;
			Log = logger;

			zenjector.OnMenu<AODMenuInstaller>();
		}
	}
}
