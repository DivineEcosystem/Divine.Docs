# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData"></a> Class CMsgGameMatchSignOutEventGameData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOutEventGameData : IMessage<CMsgGameMatchSignOutEventGameData>, IEquatable<CMsgGameMatchSignOutEventGameData>, IDeepCloneable<CMsgGameMatchSignOutEventGameData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOutEventGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutEventGameData.md)

#### Implements

IMessage<CMsgGameMatchSignOutEventGameData\>, 
[IEquatable<CMsgGameMatchSignOutEventGameData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOutEventGameData\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOutEventGameData\>\(CMsgGameMatchSignOutEventGameData, params CMsgGameMatchSignOutEventGameData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData__ctor"></a> CMsgGameMatchSignOutEventGameData\(\)

```csharp
public CMsgGameMatchSignOutEventGameData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_"></a> CMsgGameMatchSignOutEventGameData\(CMsgGameMatchSignOutEventGameData\)

```csharp
public CMsgGameMatchSignOutEventGameData(CMsgGameMatchSignOutEventGameData other)
```

#### Parameters

`other` [CMsgGameMatchSignOutEventGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutEventGameData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_EventGameDataFieldNumber"></a> EventGameDataFieldNumber

```csharp
public const int EventGameDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_GameNameFieldNumber"></a> GameNameFieldNumber

```csharp
public const int GameNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_MapNameFieldNumber"></a> MapNameFieldNumber

```csharp
public const int MapNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_EventGameData"></a> EventGameData

```csharp
public ByteString EventGameData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_GameName"></a> GameName

```csharp
public string GameName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_HasEventGameData"></a> HasEventGameData

```csharp
public bool HasEventGameData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_HasGameName"></a> HasGameName

```csharp
public bool HasGameName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_HasMapName"></a> HasMapName

```csharp
public bool HasMapName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_MapName"></a> MapName

```csharp
public string MapName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOutEventGameData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOutEventGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutEventGameData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_StartTime"></a> StartTime

```csharp
public uint StartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_ClearEventGameData"></a> ClearEventGameData\(\)

```csharp
public void ClearEventGameData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_ClearGameName"></a> ClearGameName\(\)

```csharp
public void ClearGameName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_ClearMapName"></a> ClearMapName\(\)

```csharp
public void ClearMapName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOutEventGameData Clone()
```

#### Returns

 [CMsgGameMatchSignOutEventGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutEventGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_"></a> Equals\(CMsgGameMatchSignOutEventGameData\)

```csharp
public bool Equals(CMsgGameMatchSignOutEventGameData other)
```

#### Parameters

`other` [CMsgGameMatchSignOutEventGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutEventGameData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_"></a> MergeFrom\(CMsgGameMatchSignOutEventGameData\)

```csharp
public void MergeFrom(CMsgGameMatchSignOutEventGameData other)
```

#### Parameters

`other` [CMsgGameMatchSignOutEventGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutEventGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutEventGameData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

