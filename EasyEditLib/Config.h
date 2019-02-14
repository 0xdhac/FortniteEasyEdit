#pragma once

#include <string>
#include <fstream>

class Config
{
private:
	std::string m_Path;
	std::fstream m_File;

	void CreateConfig();
	bool AttemptToOpenFile();
	void AttemptToCloseFile();
public:
	Config(std::string path);
	~Config();
	int FindValue(std::string key);
	void SetValue(std::string key, int value);
	bool m_FileExists;
	bool failed;
};