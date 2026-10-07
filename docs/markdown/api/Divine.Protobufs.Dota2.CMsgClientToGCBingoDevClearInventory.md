# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory"></a> Class CMsgClientToGCBingoDevClearInventory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoDevClearInventory : IMessage<CMsgClientToGCBingoDevClearInventory>, IEquatable<CMsgClientToGCBingoDevClearInventory>, IDeepCloneable<CMsgClientToGCBingoDevClearInventory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventory.md)

#### Implements

IMessage<CMsgClientToGCBingoDevClearInventory\>, 
[IEquatable<CMsgClientToGCBingoDevClearInventory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoDevClearInventory\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoDevClearInventory\>\(CMsgClientToGCBingoDevClearInventory, params CMsgClientToGCBingoDevClearInventory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory__ctor"></a> CMsgClientToGCBingoDevClearInventory\(\)

```csharp
public CMsgClientToGCBingoDevClearInventory()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_"></a> CMsgClientToGCBingoDevClearInventory\(CMsgClientToGCBingoDevClearInventory\)

```csharp
public CMsgClientToGCBingoDevClearInventory(CMsgClientToGCBingoDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoDevClearInventory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventory.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoDevClearInventory Clone()
```

#### Returns

 [CMsgClientToGCBingoDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventory.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_"></a> Equals\(CMsgClientToGCBingoDevClearInventory\)

```csharp
public bool Equals(CMsgClientToGCBingoDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_"></a> MergeFrom\(CMsgClientToGCBingoDevClearInventory\)

```csharp
public void MergeFrom(CMsgClientToGCBingoDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventory.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

