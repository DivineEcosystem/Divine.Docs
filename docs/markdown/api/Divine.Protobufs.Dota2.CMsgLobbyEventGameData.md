# <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData"></a> Class CMsgLobbyEventGameData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyEventGameData : IMessage<CMsgLobbyEventGameData>, IEquatable<CMsgLobbyEventGameData>, IDeepCloneable<CMsgLobbyEventGameData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyEventGameData](Divine.Protobufs.Dota2.CMsgLobbyEventGameData.md)

#### Implements

IMessage<CMsgLobbyEventGameData\>, 
[IEquatable<CMsgLobbyEventGameData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyEventGameData\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgLobbyEventGameData\>\(CMsgLobbyEventGameData, params CMsgLobbyEventGameData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData__ctor"></a> CMsgLobbyEventGameData\(\)

```csharp
public CMsgLobbyEventGameData()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData__ctor_Divine_Protobufs_Dota2_CMsgLobbyEventGameData_"></a> CMsgLobbyEventGameData\(CMsgLobbyEventGameData\)

```csharp
public CMsgLobbyEventGameData(CMsgLobbyEventGameData other)
```

#### Parameters

`other` [CMsgLobbyEventGameData](Divine.Protobufs.Dota2.CMsgLobbyEventGameData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_EventWindowStartTimeFieldNumber"></a> EventWindowStartTimeFieldNumber

```csharp
public const int EventWindowStartTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_GameSeedFieldNumber"></a> GameSeedFieldNumber

```csharp
public const int GameSeedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_EventWindowStartTime"></a> EventWindowStartTime

```csharp
public uint EventWindowStartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_GameSeed"></a> GameSeed

```csharp
public uint GameSeed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_HasEventWindowStartTime"></a> HasEventWindowStartTime

```csharp
public bool HasEventWindowStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_HasGameSeed"></a> HasGameSeed

```csharp
public bool HasGameSeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyEventGameData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyEventGameData](Divine.Protobufs.Dota2.CMsgLobbyEventGameData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_ClearEventWindowStartTime"></a> ClearEventWindowStartTime\(\)

```csharp
public void ClearEventWindowStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_ClearGameSeed"></a> ClearGameSeed\(\)

```csharp
public void ClearGameSeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyEventGameData Clone()
```

#### Returns

 [CMsgLobbyEventGameData](Divine.Protobufs.Dota2.CMsgLobbyEventGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_Equals_Divine_Protobufs_Dota2_CMsgLobbyEventGameData_"></a> Equals\(CMsgLobbyEventGameData\)

```csharp
public bool Equals(CMsgLobbyEventGameData other)
```

#### Parameters

`other` [CMsgLobbyEventGameData](Divine.Protobufs.Dota2.CMsgLobbyEventGameData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyEventGameData_"></a> MergeFrom\(CMsgLobbyEventGameData\)

```csharp
public void MergeFrom(CMsgLobbyEventGameData other)
```

#### Parameters

`other` [CMsgLobbyEventGameData](Divine.Protobufs.Dota2.CMsgLobbyEventGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

