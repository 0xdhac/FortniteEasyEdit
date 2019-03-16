#pragma once

#include <string>
#include <fstream>

class Config
{
public:
	static std::string m_Path;
	static std::fstream m_File;
	static bool failed;

	static void CreateConfig();
	static bool AttemptToOpenFile();
	static void AttemptToCloseFile();

	Config(std::string path);
	~Config();
	static int FindValue(std::string key);
	static void SetValue(std::string key, int value);
	
};