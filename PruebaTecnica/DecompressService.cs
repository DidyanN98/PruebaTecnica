using System;
using System.IO;
using System.IO.Compression;
using System.Text;

public static class DecompressService
{
    public static string Decompress(string compressedData)
    {
        var bytes = Convert.FromBase64String(compressedData);
        using (var inputStream = new MemoryStream(bytes))
        using (var decompressedStream = new GZipStream(inputStream, CompressionMode.Decompress))
        using (var resultStream = new MemoryStream())
        {
            decompressedStream.CopyTo(resultStream);
            return Encoding.UTF8.GetString(resultStream.ToArray());
        }
    }
}
