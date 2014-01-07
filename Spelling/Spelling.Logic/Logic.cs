﻿/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All code (c) Matthew Smith all rights reserved
 * 
 *   This software is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;

namespace Matt40k.Spelling
{
    public class Logic
    {
        private int? _validMaxLength = 5;
        private string _currentWord;
        private string _currentWordPath;
        private string _AppFolder = "Spelling";
        private List<string> folders = null;
        private List<string> files = new List<string>();
        private string selectedFolder = null;
        private string selected = null;
        private string defaultSelected = "The Magic Key";
        private int filesCnt = 0;

        public enum LetterTypes { Lower, Upper, Camel };
        private LetterTypes _currentLetterType = LetterTypes.Upper;

        public int? SetMaxLength
        {
            set
            {
                if (value == null || value == 0)
                {
                    // Do not set it to null or 0
                }
                else
                {
                    _validMaxLength = value;
                }
            }
        }

        public int? GetMaxLength
        {
            get
            {
                if (_validMaxLength == null || _validMaxLength == 0)
                {
                    return 5;
                }
                else
                {
                    return _validMaxLength;
                }
            }
        }

        public int GetWordLength
        {
            get
            {
                // If the name is null or empty return null length
                if (string.IsNullOrEmpty(_currentWord))
                    return 0;

                // Get the word length
                return _currentWord.Length;
            }
        }

        private int? getWordLength(string _word)
        {
            // If the name is null or empty return null length
            if (string.IsNullOrEmpty(_word))
                return null;

            // Get the word length
            return _word.Length;
        }

        public bool IsValidWord(string word)
        {
            int? wordLength = getWordLength(word);

            if (wordLength == null || wordLength == 0)
            {
                // Word length is empty
                return false;
            }
            if (wordLength > _validMaxLength)
            {
                // Word is too long
                return false;
            }

            if (!IsOnlyCharacters(word))
            {
                // Word contains non-characters
                return false;
            }

            return true;
        }

        public string GetWordNameFromFilename(string fileName)
        {
            string name = Path.GetFileNameWithoutExtension(fileName);
            return name;
        }

        public bool IsValidFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);

            switch (ext)
            {
                case ".png":
                    return true;
                case ".gif":
                    return true;
                case ".jpg":
                    return true;
                case ".bmp":
                    return true;
                default:
                    return false;
            }
        }

        public bool IsOnlyCharacters(string word)
        {
            return Regex.IsMatch(word, @"^[a-zA-Z]+$");
        }

        public string NameToUpper(string word)
        {
            return word.ToUpper();
        }

        public string NameToLower(string word)
        {
            return word.ToLower();
        }

        public string NameToCamel(string word)
        {
            TextInfo ti = new CultureInfo("en-GB", false).TextInfo;
            return ti.ToTitleCase(word);
        }

        public string GetCharacterUpperLowerCombined(string character)
        {
            if (character.Length == 1)
            {
                string upperLower = character.ToUpper() + character.ToLower();
                return upperLower;
            }
            // Character is singular letter, not a word, so if you passed a word, fall
            throw new System.ArgumentException("Character length cannot be greater then one");
        }

        private string getMyDocuments
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return path;
            }
        }

        private string GetUserStorageFolder
        {
            get
            {
                string path = Path.Combine(getMyDocuments, _AppFolder);
                return path;
            }
        }

        public List<string> GetFolderNames
        {
            get
            {
                if (folders == null)
                    folders = new List<string>(Directory.EnumerateDirectories(GetUserStorageFolder));

                List<string> folderNames = new List<string>();
                foreach (var folder in folders)
                {
                    folderNames.Add(Path.GetFileName(folder));
                }

                return folderNames;
            }
        }

        public bool HasOnlyOneFolder
        {
            get
            {
                if (folders == null)
                    folders = new List<string>(Directory.EnumerateDirectories(GetUserStorageFolder));
                if (folders.Count == 1)
                {
                    selected = folders[0];
                    return true;
                }
                return false;
            }
        }

        private List<string> GetFiles
        {
            get
            {
                if (files.Count == 0)
                {
                    List<string> uncheckedFiles = new List<string>(Directory.EnumerateFiles(GetSelectedFolder));
                    List<string> unduplicatedFiles = new List<string>();
                    foreach (var _file in uncheckedFiles)
                    {
                        if (IsValidFileType(_file))
                        {
                            if (IsValidWord(GetWordNameFromFilename(_file)))
                            {
                                unduplicatedFiles.Add(_file);
                                filesCnt = filesCnt + 1;
                            }
                        }
                    }

                    files = unduplicatedFiles.Distinct().ToList();
                }
                return files;
            }
        }

        private void ResetFiles()
        {
            files = null;
            filesCnt = 0;
        }

        private string GetSelectedFolder
        {
            get
            {
                if (selectedFolder == null)
                    return Path.Combine(GetUserStorageFolder, GetSelected);
                return Path.Combine(GetUserStorageFolder, selectedFolder);
            }
        }

        public string SetSelectedFolder
        {
            set
            {
                selectedFolder = value;
            }
        }

        private string GetSelected
        {
            get
            {
                if (selected == null)
                    return defaultSelected;
                else
                    return selected;
            }
        }

        public void GetRandomWord()
        {
            Random rnd = new Random();
            List<string> tmp = GetFiles;
            int index = rnd.Next(0, tmp.Count);
            _currentWord = GetWordNameFromFilename(tmp[index]);
            _currentWordPath = tmp[index];
            ConvertToCurrentLetterType(_currentWord);
        }

        public string GetWordPicturePath
        {
            get
            {
                return _currentWordPath;
            }
        }

        public BitmapImage GetWordPicture
        {
            get
            {
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(_currentWordPath, UriKind.RelativeOrAbsolute);
                bi.EndInit();
                return bi;
            }
        }

        public string RevealLetter(int letterNo)
        {
            string letter = _currentWord.Substring((letterNo - 1), 1);
            return letter;
        }

        public bool IsLetterCorrect(string Letter, int LetterNo)
        {
            string correctLetter = _currentWord.Substring((LetterNo - 1), 1);
            if (Letter.ToUpper() == correctLetter.ToUpper())
                return true;
            else
                return false;
        }

        public void ConvertToCurrentLetterType(string word)
        {
            string wordConverted;

            switch(_currentLetterType)
            {
                case LetterTypes.Upper:
                    wordConverted = NameToUpper(word);
                    break;
                case LetterTypes.Lower:
                   wordConverted = NameToLower(word);
                    break;
                case LetterTypes.Camel:
                    wordConverted = NameToCamel(word);
                    break;
                default:
                    wordConverted = word;
                    break;
            }
            _currentWord = wordConverted;
        }

        public LetterTypes SetLetterType
        {
            set
            {
                _currentLetterType = value;
                ConvertToCurrentLetterType(_currentWord);
            }
        }

        public LetterTypes GetLetterType
        {
            get
            {
                return _currentLetterType;
            }
        }
    }
}
