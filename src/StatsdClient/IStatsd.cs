using System;
using System.Collections.Generic;

namespace StatsdClient
{
    public interface IStatsd
    {
        List<string> Commands { get; }
        void Send<TCommandType, T>(string name, T value, double sampleRate, params string[] tags) where TCommandType : StatsdClient.Statsd.Metric;
        void Add<TCommandType, T>(string name, T value, double sampleRate, params string[] tags) where TCommandType : StatsdClient.Statsd.Metric;
        void Send(string title, string text, string alertType, string aggregationKey, string sourceType, int? dateHappened, string priority, string hostname, string[] tags, bool truncateIfTooLong = false);
        void Add(string title, string text, string alertType, string aggregationKey, string sourceType, int? dateHappened, string priority, string hostname, string[] tags);
        void Send(string command);
        void Send();
        void Add(Action actionToTime, string statName, double sampleRate, params string[] tags);
        void Send(Action actionToTime, string statName, double sampleRate, params string[] tags);
        void Add(string name, int status, int? timestamp = null, string hostname = null, string[] tags = null, string serviceCheckMessage = null);
        void Send(string name, int status, int? timestamp = null, string hostname = null, string[] tags = null, string serviceCheckMessage = null, bool truncateIfTooLong = false);
    }
}