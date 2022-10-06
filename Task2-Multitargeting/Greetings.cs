using System;

namespace Task2_Multitargeting
{
    public class Greetings
    {
        /// <summary>
        /// Generate greetings for user
        /// </summary>
        /// <param name="username"></param>
        public string GenerateGreetings(string username)
        {
            string currentTime = DateTime.Now.ToString();
            string result = $"{currentTime} Hello {username}!";
            return result;
        }
    }
}
