# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData"></a> Class CMsgClientToGCBingoGetUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoGetUserData : IMessage<CMsgClientToGCBingoGetUserData>, IEquatable<CMsgClientToGCBingoGetUserData>, IDeepCloneable<CMsgClientToGCBingoGetUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserData.md)

#### Implements

IMessage<CMsgClientToGCBingoGetUserData\>, 
[IEquatable<CMsgClientToGCBingoGetUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoGetUserData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoGetUserData\>\(CMsgClientToGCBingoGetUserData, params CMsgClientToGCBingoGetUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData__ctor"></a> CMsgClientToGCBingoGetUserData\(\)

```csharp
public CMsgClientToGCBingoGetUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_"></a> CMsgClientToGCBingoGetUserData\(CMsgClientToGCBingoGetUserData\)

```csharp
public CMsgClientToGCBingoGetUserData(CMsgClientToGCBingoGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoGetUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoGetUserData Clone()
```

#### Returns

 [CMsgClientToGCBingoGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_"></a> Equals\(CMsgClientToGCBingoGetUserData\)

```csharp
public bool Equals(CMsgClientToGCBingoGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_"></a> MergeFrom\(CMsgClientToGCBingoGetUserData\)

```csharp
public void MergeFrom(CMsgClientToGCBingoGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

