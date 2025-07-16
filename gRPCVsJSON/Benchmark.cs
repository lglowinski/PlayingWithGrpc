using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Bogus;
using Google.Protobuf;

namespace gRPCVsJSON;

[MemoryDiagnoser(false)]
public class Benchmark
{
    private List<UserDto>? _jsonUsers;
    private List<string>? _jsonStrings;
    
    private List<User>? _protobufUsers;
    private List<byte[]> _protobufBytes;
    
    [Params(10_000, 100_000, 1_000_000)]
    public int Size;
    
    [GlobalSetup]
    public void Setup()
    {
        var faker = new Faker();
        _jsonUsers = [];
        _protobufUsers = [];
        _jsonStrings = [];
        _protobufBytes = [];
        
        for (var i = 0; i < Size; i++)
        {
            var id = faker.Random.Int(0, Size);
            var name = faker.Person.FullName;
            var isActive = faker.Random.Bool();

            var jsonUser = new UserDto
            {
                Id = id,
                Name = name,
                IsActive = isActive
            };

            var protobufUser = new User
            {
                Id = id,
                Name = name,
                IsActive = isActive
            };
            
            _jsonUsers.Add(jsonUser);
            _protobufUsers.Add(protobufUser);
            
            _jsonStrings.Add(JsonSerializer.Serialize(jsonUser));
            _protobufBytes.Add(protobufUser.ToByteArray());
        }
    }

    [Benchmark]
    public void JsonSerialization()
    {
        foreach (var user in _jsonUsers)
        {
           _ = JsonSerializer.Serialize(user);
        }
    }

    [Benchmark]
    public void ProtobufSerialization()
    {
        foreach (var user in _protobufUsers)
        {
            _ = user.ToByteArray();
        }
    }

    [Benchmark]
    public void JsonDeserialization()
    {
        foreach (var json in _jsonStrings)
        {
            _ = JsonSerializer.Deserialize<UserDto>(json);
        }
    }

    [Benchmark]
    public void ProtobufDeserialization()
    {
        foreach (var bytes in _protobufBytes)
        {
            _ = User.Parser.ParseFrom(bytes);
        }
    }
}