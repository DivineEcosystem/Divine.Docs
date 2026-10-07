# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle"></a> Class CMsgClientToGCPackBundle

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPackBundle : IMessage<CMsgClientToGCPackBundle>, IEquatable<CMsgClientToGCPackBundle>, IDeepCloneable<CMsgClientToGCPackBundle>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPackBundle](Divine.Protobufs.Dota2.CMsgClientToGCPackBundle.md)

#### Implements

IMessage<CMsgClientToGCPackBundle\>, 
[IEquatable<CMsgClientToGCPackBundle\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPackBundle\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPackBundle\>\(CMsgClientToGCPackBundle, params CMsgClientToGCPackBundle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle__ctor"></a> CMsgClientToGCPackBundle\(\)

```csharp
public CMsgClientToGCPackBundle()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_"></a> CMsgClientToGCPackBundle\(CMsgClientToGCPackBundle\)

```csharp
public CMsgClientToGCPackBundle(CMsgClientToGCPackBundle other)
```

#### Parameters

`other` [CMsgClientToGCPackBundle](Divine.Protobufs.Dota2.CMsgClientToGCPackBundle.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_BundleItemDefIndexFieldNumber"></a> BundleItemDefIndexFieldNumber

```csharp
public const int BundleItemDefIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_BundleItemDefIndex"></a> BundleItemDefIndex

```csharp
public uint BundleItemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_HasBundleItemDefIndex"></a> HasBundleItemDefIndex

```csharp
public bool HasBundleItemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_ItemIds"></a> ItemIds

```csharp
public RepeatedField<ulong> ItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPackBundle> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPackBundle](Divine.Protobufs.Dota2.CMsgClientToGCPackBundle.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_ClearBundleItemDefIndex"></a> ClearBundleItemDefIndex\(\)

```csharp
public void ClearBundleItemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPackBundle Clone()
```

#### Returns

 [CMsgClientToGCPackBundle](Divine.Protobufs.Dota2.CMsgClientToGCPackBundle.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_"></a> Equals\(CMsgClientToGCPackBundle\)

```csharp
public bool Equals(CMsgClientToGCPackBundle other)
```

#### Parameters

`other` [CMsgClientToGCPackBundle](Divine.Protobufs.Dota2.CMsgClientToGCPackBundle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_"></a> MergeFrom\(CMsgClientToGCPackBundle\)

```csharp
public void MergeFrom(CMsgClientToGCPackBundle other)
```

#### Parameters

`other` [CMsgClientToGCPackBundle](Divine.Protobufs.Dota2.CMsgClientToGCPackBundle.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPackBundle_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

