using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class SensorDataNormalizer : IStringParser, INumberRounder
{
    public float? ParseValue(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return null;

        input = input.Trim();

        if (input.Equals("null", StringComparison.OrdinalIgnoreCase) ||
            input.Equals("NaN", StringComparison.OrdinalIgnoreCase) ||
            input.Equals("error", StringComparison.OrdinalIgnoreCase))
            return null;

        if (float.TryParse(input, NumberStyles.Float,
            CultureInfo.InvariantCulture, out float value))
            return value;

        return null;
    }

    public float Round(float value)
    {
        return (float)Math.Round(value, 2);
    }

    public float[] Normalize(string raw)
    {
        if (string.IsNullOrWhiteSpace(raw))
            return null;

        var results = new List<float>();

        string[] parts = raw.Split(',');

        foreach (var part in parts)
        {
            float? parsed = ParseValue(part);

            if (parsed.HasValue)
                results.Add(Round(parsed.Value));
        }

        return results.Count > 0 ? results.ToArray() : null;
    }
}
