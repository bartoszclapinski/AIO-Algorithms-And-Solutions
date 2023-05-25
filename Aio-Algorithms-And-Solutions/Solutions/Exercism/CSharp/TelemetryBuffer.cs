namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] bytes;
        byte prefix;

        
        switch (reading)
        {
            case >= ushort.MinValue and <= ushort.MaxValue:
                bytes = BitConverter.GetBytes((ushort)reading);
                prefix = 2;
                break;
            case >= short.MinValue and <= short.MaxValue:
                bytes = BitConverter.GetBytes((short)reading);
                prefix = 256 - 2;
                break;
            case >= int.MinValue and <= int.MaxValue:
                bytes = BitConverter.GetBytes((int)reading);
                prefix = 256 - 4;
                break;
            case >= uint.MinValue and <= uint.MaxValue:
                bytes = BitConverter.GetBytes((uint)reading);
                prefix = 4;
                break;
            case >= long.MinValue and <= long.MaxValue:
                bytes = BitConverter.GetBytes(reading);
                prefix = 256 - 8;
                break;
            default:
                throw new ArgumentException("Unsupported type");
        }

        var result = new byte[9];
        result[0] = prefix;
        Array.Copy(bytes, 0, result, 1, bytes.Length);

        return result;
        
    }

    public static long FromBuffer(byte[] buffer)
    {
        var prefix = buffer[0];
        var bytes = new byte[8];
        Array.Copy(buffer, 1, bytes, 0, bytes.Length);

        return prefix switch
        {
            0xfc => // Int32
                BitConverter.ToInt32(bytes, 0),
            0xf8 => // Int64
                BitConverter.ToInt64(bytes, 0),
            0xfe => // Int16
                BitConverter.ToInt16(bytes, 0),
            0x04 => // UInt32
                BitConverter.ToUInt32(bytes, 0),
            0x02 => // UInt16
                BitConverter.ToUInt16(bytes, 0),
            _ => 0
        };
    }    
}