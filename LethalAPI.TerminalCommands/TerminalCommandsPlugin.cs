﻿using BepInEx;
using HarmonyLib;
using LethalAPI.TerminalCommands.Commands;
using LethalAPI.TerminalCommands.Configs;
using LethalAPI.TerminalCommands.Models;

namespace LethalAPI.TerminalCommands
{
	[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
	public class TerminalCommandsPlugin : BaseUnityPlugin
	{
		private Harmony HarmonyInstance = new Harmony(PluginInfo.PLUGIN_GUID);

		private ModCommands Terminal;

		private TerminalConfig m_Config;

		private void Awake()
		{
			try
			{
				Logger.LogInfo($"{PluginInfo.PLUGIN_GUID} is loading...");

				Logger.LogInfo($"Installing patches");
				HarmonyInstance.PatchAll(typeof(TerminalCommandsPlugin).Assembly);

				Logger.LogInfo($"Registering built-in Commands");

				// Create registry for the Terminals API
				Terminal = TerminalRegistry.CreateTerminalRegistry();

				// Register commands, don't care about the instance
				Terminal.RegisterFrom<CommandInfoCommands>();
				Terminal.RegisterFrom<ConfigurationCommands>();

				// Register configs, and load saved values
				m_Config = Terminal.RegisterFrom<TerminalConfig>();

				DontDestroyOnLoad(this);

				Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
			}
			catch (System.Exception ex)
			{
				Logger.LogError(ex.Message);
				Logger.LogError(ex.StackTrace);
				throw;
			}
		}
	}
}
