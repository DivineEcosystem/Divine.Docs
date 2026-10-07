# <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig"></a> Class CMsgServerToGCGetCheerConfig

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCGetCheerConfig : IMessage<CMsgServerToGCGetCheerConfig>, IEquatable<CMsgServerToGCGetCheerConfig>, IDeepCloneable<CMsgServerToGCGetCheerConfig>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCGetCheerConfig](Divine.Protobufs.Dota2.CMsgServerToGCGetCheerConfig.md)

#### Implements

IMessage<CMsgServerToGCGetCheerConfig\>, 
[IEquatable<CMsgServerToGCGetCheerConfig\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCGetCheerConfig\>, 
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
[EnumerableExtensions.In<CMsgServerToGCGetCheerConfig\>\(CMsgServerToGCGetCheerConfig, params CMsgServerToGCGetCheerConfig\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig__ctor"></a> CMsgServerToGCGetCheerConfig\(\)

```csharp
public CMsgServerToGCGetCheerConfig()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig__ctor_Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_"></a> CMsgServerToGCGetCheerConfig\(CMsgServerToGCGetCheerConfig\)

```csharp
public CMsgServerToGCGetCheerConfig(CMsgServerToGCGetCheerConfig other)
```

#### Parameters

`other` [CMsgServerToGCGetCheerConfig](Divine.Protobufs.Dota2.CMsgServerToGCGetCheerConfig.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCGetCheerConfig> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCGetCheerConfig](Divine.Protobufs.Dota2.CMsgServerToGCGetCheerConfig.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCGetCheerConfig Clone()
```

#### Returns

 [CMsgServerToGCGetCheerConfig](Divine.Protobufs.Dota2.CMsgServerToGCGetCheerConfig.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_Equals_Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_"></a> Equals\(CMsgServerToGCGetCheerConfig\)

```csharp
public bool Equals(CMsgServerToGCGetCheerConfig other)
```

#### Parameters

`other` [CMsgServerToGCGetCheerConfig](Divine.Protobufs.Dota2.CMsgServerToGCGetCheerConfig.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_"></a> MergeFrom\(CMsgServerToGCGetCheerConfig\)

```csharp
public void MergeFrom(CMsgServerToGCGetCheerConfig other)
```

#### Parameters

`other` [CMsgServerToGCGetCheerConfig](Divine.Protobufs.Dota2.CMsgServerToGCGetCheerConfig.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetCheerConfig_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

