# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable"></a> Class CDOTAUserMsg\_NeutralCraftAvailable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_NeutralCraftAvailable : IMessage<CDOTAUserMsg_NeutralCraftAvailable>, IEquatable<CDOTAUserMsg_NeutralCraftAvailable>, IDeepCloneable<CDOTAUserMsg_NeutralCraftAvailable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_NeutralCraftAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCraftAvailable.md)

#### Implements

IMessage<CDOTAUserMsg\_NeutralCraftAvailable\>, 
[IEquatable<CDOTAUserMsg\_NeutralCraftAvailable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_NeutralCraftAvailable\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_NeutralCraftAvailable\>\(CDOTAUserMsg\_NeutralCraftAvailable, params CDOTAUserMsg\_NeutralCraftAvailable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable__ctor"></a> CDOTAUserMsg\_NeutralCraftAvailable\(\)

```csharp
public CDOTAUserMsg_NeutralCraftAvailable()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_"></a> CDOTAUserMsg\_NeutralCraftAvailable\(CDOTAUserMsg\_NeutralCraftAvailable\)

```csharp
public CDOTAUserMsg_NeutralCraftAvailable(CDOTAUserMsg_NeutralCraftAvailable other)
```

#### Parameters

`other` [CDOTAUserMsg\_NeutralCraftAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCraftAvailable.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_NeutralCraftAvailable> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_NeutralCraftAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCraftAvailable.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_NeutralCraftAvailable Clone()
```

#### Returns

 [CDOTAUserMsg\_NeutralCraftAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCraftAvailable.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_"></a> Equals\(CDOTAUserMsg\_NeutralCraftAvailable\)

```csharp
public bool Equals(CDOTAUserMsg_NeutralCraftAvailable other)
```

#### Parameters

`other` [CDOTAUserMsg\_NeutralCraftAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCraftAvailable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_"></a> MergeFrom\(CDOTAUserMsg\_NeutralCraftAvailable\)

```csharp
public void MergeFrom(CDOTAUserMsg_NeutralCraftAvailable other)
```

#### Parameters

`other` [CDOTAUserMsg\_NeutralCraftAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCraftAvailable.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCraftAvailable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

