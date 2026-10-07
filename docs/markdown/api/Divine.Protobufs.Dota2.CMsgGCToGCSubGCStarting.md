# <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting"></a> Class CMsgGCToGCSubGCStarting

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCSubGCStarting : IMessage<CMsgGCToGCSubGCStarting>, IEquatable<CMsgGCToGCSubGCStarting>, IDeepCloneable<CMsgGCToGCSubGCStarting>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCSubGCStarting](Divine.Protobufs.Dota2.CMsgGCToGCSubGCStarting.md)

#### Implements

IMessage<CMsgGCToGCSubGCStarting\>, 
[IEquatable<CMsgGCToGCSubGCStarting\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCSubGCStarting\>, 
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
[EnumerableExtensions.In<CMsgGCToGCSubGCStarting\>\(CMsgGCToGCSubGCStarting, params CMsgGCToGCSubGCStarting\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting__ctor"></a> CMsgGCToGCSubGCStarting\(\)

```csharp
public CMsgGCToGCSubGCStarting()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting__ctor_Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_"></a> CMsgGCToGCSubGCStarting\(CMsgGCToGCSubGCStarting\)

```csharp
public CMsgGCToGCSubGCStarting(CMsgGCToGCSubGCStarting other)
```

#### Parameters

`other` [CMsgGCToGCSubGCStarting](Divine.Protobufs.Dota2.CMsgGCToGCSubGCStarting.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_DirIndexFieldNumber"></a> DirIndexFieldNumber

```csharp
public const int DirIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_DirIndex"></a> DirIndex

```csharp
public int DirIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_HasDirIndex"></a> HasDirIndex

```csharp
public bool HasDirIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCSubGCStarting> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCSubGCStarting](Divine.Protobufs.Dota2.CMsgGCToGCSubGCStarting.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_ClearDirIndex"></a> ClearDirIndex\(\)

```csharp
public void ClearDirIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCSubGCStarting Clone()
```

#### Returns

 [CMsgGCToGCSubGCStarting](Divine.Protobufs.Dota2.CMsgGCToGCSubGCStarting.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_Equals_Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_"></a> Equals\(CMsgGCToGCSubGCStarting\)

```csharp
public bool Equals(CMsgGCToGCSubGCStarting other)
```

#### Parameters

`other` [CMsgGCToGCSubGCStarting](Divine.Protobufs.Dota2.CMsgGCToGCSubGCStarting.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_"></a> MergeFrom\(CMsgGCToGCSubGCStarting\)

```csharp
public void MergeFrom(CMsgGCToGCSubGCStarting other)
```

#### Parameters

`other` [CMsgGCToGCSubGCStarting](Divine.Protobufs.Dota2.CMsgGCToGCSubGCStarting.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSubGCStarting_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

