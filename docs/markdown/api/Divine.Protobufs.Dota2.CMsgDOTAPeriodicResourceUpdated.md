# <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated"></a> Class CMsgDOTAPeriodicResourceUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPeriodicResourceUpdated : IMessage<CMsgDOTAPeriodicResourceUpdated>, IEquatable<CMsgDOTAPeriodicResourceUpdated>, IDeepCloneable<CMsgDOTAPeriodicResourceUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPeriodicResourceUpdated](Divine.Protobufs.Dota2.CMsgDOTAPeriodicResourceUpdated.md)

#### Implements

IMessage<CMsgDOTAPeriodicResourceUpdated\>, 
[IEquatable<CMsgDOTAPeriodicResourceUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPeriodicResourceUpdated\>, 
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
[EnumerableExtensions.In<CMsgDOTAPeriodicResourceUpdated\>\(CMsgDOTAPeriodicResourceUpdated, params CMsgDOTAPeriodicResourceUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated__ctor"></a> CMsgDOTAPeriodicResourceUpdated\(\)

```csharp
public CMsgDOTAPeriodicResourceUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated__ctor_Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_"></a> CMsgDOTAPeriodicResourceUpdated\(CMsgDOTAPeriodicResourceUpdated\)

```csharp
public CMsgDOTAPeriodicResourceUpdated(CMsgDOTAPeriodicResourceUpdated other)
```

#### Parameters

`other` [CMsgDOTAPeriodicResourceUpdated](Divine.Protobufs.Dota2.CMsgDOTAPeriodicResourceUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_PeriodicResourceKeyFieldNumber"></a> PeriodicResourceKeyFieldNumber

```csharp
public const int PeriodicResourceKeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_PeriodicResourceValueFieldNumber"></a> PeriodicResourceValueFieldNumber

```csharp
public const int PeriodicResourceValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPeriodicResourceUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPeriodicResourceUpdated](Divine.Protobufs.Dota2.CMsgDOTAPeriodicResourceUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_PeriodicResourceKey"></a> PeriodicResourceKey

```csharp
public CMsgDOTAGetPeriodicResource PeriodicResourceKey { get; set; }
```

#### Property Value

 [CMsgDOTAGetPeriodicResource](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResource.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_PeriodicResourceValue"></a> PeriodicResourceValue

```csharp
public CMsgDOTAGetPeriodicResourceResponse PeriodicResourceValue { get; set; }
```

#### Property Value

 [CMsgDOTAGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResourceResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPeriodicResourceUpdated Clone()
```

#### Returns

 [CMsgDOTAPeriodicResourceUpdated](Divine.Protobufs.Dota2.CMsgDOTAPeriodicResourceUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_Equals_Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_"></a> Equals\(CMsgDOTAPeriodicResourceUpdated\)

```csharp
public bool Equals(CMsgDOTAPeriodicResourceUpdated other)
```

#### Parameters

`other` [CMsgDOTAPeriodicResourceUpdated](Divine.Protobufs.Dota2.CMsgDOTAPeriodicResourceUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_"></a> MergeFrom\(CMsgDOTAPeriodicResourceUpdated\)

```csharp
public void MergeFrom(CMsgDOTAPeriodicResourceUpdated other)
```

#### Parameters

`other` [CMsgDOTAPeriodicResourceUpdated](Divine.Protobufs.Dota2.CMsgDOTAPeriodicResourceUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPeriodicResourceUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

