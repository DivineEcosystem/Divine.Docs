# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated"></a> Class CMsgGCToClientBingoUserDataUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBingoUserDataUpdated : IMessage<CMsgGCToClientBingoUserDataUpdated>, IEquatable<CMsgGCToClientBingoUserDataUpdated>, IDeepCloneable<CMsgGCToClientBingoUserDataUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBingoUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientBingoUserDataUpdated.md)

#### Implements

IMessage<CMsgGCToClientBingoUserDataUpdated\>, 
[IEquatable<CMsgGCToClientBingoUserDataUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBingoUserDataUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBingoUserDataUpdated\>\(CMsgGCToClientBingoUserDataUpdated, params CMsgGCToClientBingoUserDataUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated__ctor"></a> CMsgGCToClientBingoUserDataUpdated\(\)

```csharp
public CMsgGCToClientBingoUserDataUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_"></a> CMsgGCToClientBingoUserDataUpdated\(CMsgGCToClientBingoUserDataUpdated\)

```csharp
public CMsgGCToClientBingoUserDataUpdated(CMsgGCToClientBingoUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientBingoUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientBingoUserDataUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBingoUserDataUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBingoUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientBingoUserDataUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_UserData"></a> UserData

```csharp
public CMsgBingoUserData UserData { get; set; }
```

#### Property Value

 [CMsgBingoUserData](Divine.Protobufs.Dota2.CMsgBingoUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBingoUserDataUpdated Clone()
```

#### Returns

 [CMsgGCToClientBingoUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientBingoUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_"></a> Equals\(CMsgGCToClientBingoUserDataUpdated\)

```csharp
public bool Equals(CMsgGCToClientBingoUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientBingoUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientBingoUserDataUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_"></a> MergeFrom\(CMsgGCToClientBingoUserDataUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientBingoUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientBingoUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientBingoUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBingoUserDataUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

