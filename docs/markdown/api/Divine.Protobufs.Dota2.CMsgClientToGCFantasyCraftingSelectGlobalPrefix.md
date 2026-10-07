# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix"></a> Class CMsgClientToGCFantasyCraftingSelectGlobalPrefix

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingSelectGlobalPrefix : IMessage<CMsgClientToGCFantasyCraftingSelectGlobalPrefix>, IEquatable<CMsgClientToGCFantasyCraftingSelectGlobalPrefix>, IDeepCloneable<CMsgClientToGCFantasyCraftingSelectGlobalPrefix>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingSelectGlobalPrefix](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalPrefix.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingSelectGlobalPrefix\>, 
[IEquatable<CMsgClientToGCFantasyCraftingSelectGlobalPrefix\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingSelectGlobalPrefix\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingSelectGlobalPrefix\>\(CMsgClientToGCFantasyCraftingSelectGlobalPrefix, params CMsgClientToGCFantasyCraftingSelectGlobalPrefix\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix__ctor"></a> CMsgClientToGCFantasyCraftingSelectGlobalPrefix\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectGlobalPrefix()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_"></a> CMsgClientToGCFantasyCraftingSelectGlobalPrefix\(CMsgClientToGCFantasyCraftingSelectGlobalPrefix\)

```csharp
public CMsgClientToGCFantasyCraftingSelectGlobalPrefix(CMsgClientToGCFantasyCraftingSelectGlobalPrefix other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectGlobalPrefix](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalPrefix.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_FantasyLeagueFieldNumber"></a> FantasyLeagueFieldNumber

```csharp
public const int FantasyLeagueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_PrefixFieldNumber"></a> PrefixFieldNumber

```csharp
public const int PrefixFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_FantasyLeague"></a> FantasyLeague

```csharp
public uint FantasyLeague { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_HasFantasyLeague"></a> HasFantasyLeague

```csharp
public bool HasFantasyLeague { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_HasPrefix"></a> HasPrefix

```csharp
public bool HasPrefix { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingSelectGlobalPrefix> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingSelectGlobalPrefix](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalPrefix.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_Prefix"></a> Prefix

```csharp
public uint Prefix { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_ClearFantasyLeague"></a> ClearFantasyLeague\(\)

```csharp
public void ClearFantasyLeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_ClearPrefix"></a> ClearPrefix\(\)

```csharp
public void ClearPrefix()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectGlobalPrefix Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingSelectGlobalPrefix](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalPrefix.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_"></a> Equals\(CMsgClientToGCFantasyCraftingSelectGlobalPrefix\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingSelectGlobalPrefix other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectGlobalPrefix](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalPrefix.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingSelectGlobalPrefix\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingSelectGlobalPrefix other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectGlobalPrefix](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalPrefix.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalPrefix_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

