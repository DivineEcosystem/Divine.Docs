# <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel"></a> Class CMsgRequestCrateEscalationLevel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRequestCrateEscalationLevel : IMessage<CMsgRequestCrateEscalationLevel>, IEquatable<CMsgRequestCrateEscalationLevel>, IDeepCloneable<CMsgRequestCrateEscalationLevel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRequestCrateEscalationLevel](Divine.Protobufs.Dota2.CMsgRequestCrateEscalationLevel.md)

#### Implements

IMessage<CMsgRequestCrateEscalationLevel\>, 
[IEquatable<CMsgRequestCrateEscalationLevel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRequestCrateEscalationLevel\>, 
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
[EnumerableExtensions.In<CMsgRequestCrateEscalationLevel\>\(CMsgRequestCrateEscalationLevel, params CMsgRequestCrateEscalationLevel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel__ctor"></a> CMsgRequestCrateEscalationLevel\(\)

```csharp
public CMsgRequestCrateEscalationLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel__ctor_Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_"></a> CMsgRequestCrateEscalationLevel\(CMsgRequestCrateEscalationLevel\)

```csharp
public CMsgRequestCrateEscalationLevel(CMsgRequestCrateEscalationLevel other)
```

#### Parameters

`other` [CMsgRequestCrateEscalationLevel](Divine.Protobufs.Dota2.CMsgRequestCrateEscalationLevel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_CrateItemDefFieldNumber"></a> CrateItemDefFieldNumber

```csharp
public const int CrateItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_CrateItemDef"></a> CrateItemDef

```csharp
public uint CrateItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_HasCrateItemDef"></a> HasCrateItemDef

```csharp
public bool HasCrateItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRequestCrateEscalationLevel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRequestCrateEscalationLevel](Divine.Protobufs.Dota2.CMsgRequestCrateEscalationLevel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_ClearCrateItemDef"></a> ClearCrateItemDef\(\)

```csharp
public void ClearCrateItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_Clone"></a> Clone\(\)

```csharp
public CMsgRequestCrateEscalationLevel Clone()
```

#### Returns

 [CMsgRequestCrateEscalationLevel](Divine.Protobufs.Dota2.CMsgRequestCrateEscalationLevel.md)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_Equals_Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_"></a> Equals\(CMsgRequestCrateEscalationLevel\)

```csharp
public bool Equals(CMsgRequestCrateEscalationLevel other)
```

#### Parameters

`other` [CMsgRequestCrateEscalationLevel](Divine.Protobufs.Dota2.CMsgRequestCrateEscalationLevel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_MergeFrom_Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_"></a> MergeFrom\(CMsgRequestCrateEscalationLevel\)

```csharp
public void MergeFrom(CMsgRequestCrateEscalationLevel other)
```

#### Parameters

`other` [CMsgRequestCrateEscalationLevel](Divine.Protobufs.Dota2.CMsgRequestCrateEscalationLevel.md)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateEscalationLevel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

