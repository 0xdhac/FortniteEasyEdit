#include "stdafx.h"
#include "Config.h"
#include <fstream>
#include <Windows.h>
#include <vector>

Config::Config(std::string file)
{
	char dirPath[512];
	GetCurrentDirectoryA(512, dirPath);

	char baskSlash[2] = "\\";
	m_Path = dirPath + std::string("\\") + file;
	std::cout << m_Path.c_str() << std::endl;

	struct stat buffer;
	if ((stat(m_Path.c_str(), &buffer) != 0))
	{
		FILE* f;
		fopen_s(&f, file.c_str(), "w");

		if (f)
		{
			failed = true;
		}
		else
		{
			failed = false;
			fclose(f);
			CreateConfig();
		}
	}
	else
	{
		failed = false;
	}
}

Config::~Config()
{
	AttemptToCloseFile();
}

void Config::CreateConfig()
{
	if (AttemptToOpenFile())
	{
		std::string line;
		line += "FakeEdit=" + std::to_string(VK_LSHIFT) + "\n";
		line += "RealEdit=" + std::to_string((int)'L') + "\n";
		line += "WallRetake=" + std::to_string((int)'G') + "\n";
		line += "Shotgun=" + std::to_string((int)'3') + "\n";
		line += "Floor=" + std::to_string((int)'Q') + "\n";
		line += "Stair=" + std::to_string((int)'C') + "\n";
		line += "Cone=" + std::to_string(VK_XBUTTON1) + "\n";
		line += "Wall=" + std::to_string(VK_XBUTTON2) + "\n";
		line += "Weapon1=" + std::to_string((int)'1') + "\n";
		line += "Weapon2=" + std::to_string((int)'2') + "\n";
		line += "Weapon3=" + std::to_string((int)'3') + "\n";
		line += "Weapon4=" + std::to_string((int)'4') + "\n";
		line += "Weapon5=" + std::to_string((int)'5') + "\n";
		line += "Weapon6=" + std::to_string((int)'6') + "\n";

		m_File.write(line.c_str(), line.size());

		AttemptToCloseFile();
	}
}

bool Config::AttemptToOpenFile()
{
	if (failed)
	{
		return false;
	}

	if (m_File.is_open())
	{
		m_File.clear();
		m_File.seekg(0, std::ios::beg);
		return true;
	}

	m_File = std::fstream(m_Path.c_str(), std::ios::out | std::ios::in);
	m_File.clear();
	m_File.seekg(0, std::ios::beg);

	return m_File.is_open();
}

void Config::AttemptToCloseFile()
{
	m_File.close();
}

int Config::FindValue(std::string key)
{
	if (AttemptToOpenFile())
	{
		key += "=";
		std::string line;
		while (getline(m_File, line, '\n'))
		{
			if (line.find(key) != std::string::npos)
			{
				unsigned int index = line.find("=");
				if (index != std::string::npos)
				{
					index++;
					std::string sValue;

					for (; line[index] != '\n' && index < line.length(); index++)
					{
						sValue += line[index];
					}

					return std::stoi(sValue);
				}
			}
		}

		AttemptToCloseFile();
	}

	return 0;
}

void Config::SetValue(std::string key, int value)
{
	if (AttemptToOpenFile())
	{
		key += "=";
		std::string line;
		std::vector<std::string> lines;
		while (getline(m_File, line, '\n'))
		{
			if (line.find(key) != std::string::npos)
			{
				line = key + std::to_string(value);
			}

			line += '\n'; // Add newline char since it's not included from the getline function
			lines.push_back(line);
		}

		AttemptToCloseFile();


		// Reopen file with std::ios::trunc, this way the contents of the file are deleted and added new values afterward
		m_File = std::fstream(m_Path.c_str(), std::ios::out | std::ios::trunc);
		m_File.clear();
		m_File.seekg(0, std::ios::beg);

		if (m_File.is_open())
		{
			for (unsigned int idx = 0; idx < lines.size(); idx++)
			{
				m_File.write(lines[idx].c_str(), lines[idx].length());
			}

			AttemptToCloseFile();
		}
	}

}
