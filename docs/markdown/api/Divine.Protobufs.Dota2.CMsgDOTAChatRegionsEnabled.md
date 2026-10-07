# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled"></a> Class CMsgDOTAChatRegionsEnabled

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatRegionsEnabled : IMessage<CMsgDOTAChatRegionsEnabled>, IEquatable<CMsgDOTAChatRegionsEnabled>, IDeepCloneable<CMsgDOTAChatRegionsEnabled>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md)

#### Implements

IMessage<CMsgDOTAChatRegionsEnabled\>, 
[IEquatable<CMsgDOTAChatRegionsEnabled\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatRegionsEnabled\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatRegionsEnabled\>\(CMsgDOTAChatRegionsEnabled, params CMsgDOTAChatRegionsEnabled\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled__ctor"></a> CMsgDOTAChatRegionsEnabled\(\)

```csharp
public CMsgDOTAChatRegionsEnabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_"></a> CMsgDOTAChatRegionsEnabled\(CMsgDOTAChatRegionsEnabled\)

```csharp
public CMsgDOTAChatRegionsEnabled(CMsgDOTAChatRegionsEnabled other)
```

#### Parameters

`other` [CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_EnableAllRegionsFieldNumber"></a> EnableAllRegionsFieldNumber

```csharp
public const int EnableAllRegionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_EnabledRegionsFieldNumber"></a> EnabledRegionsFieldNumber

```csharp
public const int EnabledRegionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_EnableAllRegions"></a> EnableAllRegions

```csharp
public bool EnableAllRegions { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_EnabledRegions"></a> EnabledRegions

```csharp
public RepeatedField<CMsgDOTAChatRegionsEnabled.Types.Region> EnabledRegions { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.md).[Region](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.Region.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_HasEnableAllRegions"></a> HasEnableAllRegions

```csharp
public bool HasEnableAllRegions { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatRegionsEnabled> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_ClearEnableAllRegions"></a> ClearEnableAllRegions\(\)

```csharp
public void ClearEnableAllRegions()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatRegionsEnabled Clone()
```

#### Returns

 [CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_"></a> Equals\(CMsgDOTAChatRegionsEnabled\)

```csharp
public bool Equals(CMsgDOTAChatRegionsEnabled other)
```

#### Parameters

`other` [CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_"></a> MergeFrom\(CMsgDOTAChatRegionsEnabled\)

```csharp
public void MergeFrom(CMsgDOTAChatRegionsEnabled other)
```

#### Parameters

`other` [CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

