# <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig"></a> Class CMsgGCToServerCheerConfig

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerCheerConfig : IMessage<CMsgGCToServerCheerConfig>, IEquatable<CMsgGCToServerCheerConfig>, IDeepCloneable<CMsgGCToServerCheerConfig>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerCheerConfig](Divine.Protobufs.Dota2.CMsgGCToServerCheerConfig.md)

#### Implements

IMessage<CMsgGCToServerCheerConfig\>, 
[IEquatable<CMsgGCToServerCheerConfig\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerCheerConfig\>, 
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
[EnumerableExtensions.In<CMsgGCToServerCheerConfig\>\(CMsgGCToServerCheerConfig, params CMsgGCToServerCheerConfig\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig__ctor"></a> CMsgGCToServerCheerConfig\(\)

```csharp
public CMsgGCToServerCheerConfig()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig__ctor_Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_"></a> CMsgGCToServerCheerConfig\(CMsgGCToServerCheerConfig\)

```csharp
public CMsgGCToServerCheerConfig(CMsgGCToServerCheerConfig other)
```

#### Parameters

`other` [CMsgGCToServerCheerConfig](Divine.Protobufs.Dota2.CMsgGCToServerCheerConfig.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_CheerConfigFieldNumber"></a> CheerConfigFieldNumber

```csharp
public const int CheerConfigFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_CheerConfig"></a> CheerConfig

```csharp
public CMsgCheerConfig CheerConfig { get; set; }
```

#### Property Value

 [CMsgCheerConfig](Divine.Protobufs.Dota2.CMsgCheerConfig.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerCheerConfig> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerCheerConfig](Divine.Protobufs.Dota2.CMsgGCToServerCheerConfig.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerCheerConfig Clone()
```

#### Returns

 [CMsgGCToServerCheerConfig](Divine.Protobufs.Dota2.CMsgGCToServerCheerConfig.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_Equals_Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_"></a> Equals\(CMsgGCToServerCheerConfig\)

```csharp
public bool Equals(CMsgGCToServerCheerConfig other)
```

#### Parameters

`other` [CMsgGCToServerCheerConfig](Divine.Protobufs.Dota2.CMsgGCToServerCheerConfig.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_"></a> MergeFrom\(CMsgGCToServerCheerConfig\)

```csharp
public void MergeFrom(CMsgGCToServerCheerConfig other)
```

#### Parameters

`other` [CMsgGCToServerCheerConfig](Divine.Protobufs.Dota2.CMsgGCToServerCheerConfig.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerConfig_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

