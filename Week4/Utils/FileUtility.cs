using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Week4.Utils
{
    public class FileUtility
    {
        public static String[] toStringArray(String path, int numLines = -1, String delimiterPattern = "[^A-Za-z']+")
        {
            return (numLines >= 0 ? File.ReadAllLines(path).Take(numLines) : File.ReadAllLines(path))
                .SelectMany(line => Regex.Split(line, delimiterPattern))
                .Where(word => !String.IsNullOrEmpty(word))
                .Select(word => word.ToLower())
                .ToArray<string>();

        //     //From Java
        //     // return Files.lines(Paths.get(path))
        //     //     .flatMap(line -> Stream.of(line.split(delimiterPattern)))
        //     //     .filter(word -> !word.isEmpty())
        //     //     .map(word -> word.toLowerCase())
        //     //     .toArray(String[]::new);
        }
    }
}