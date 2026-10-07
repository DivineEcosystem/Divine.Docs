# <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks"></a> Class CDemoCustomDataCallbacks

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoCustomDataCallbacks : IMessage<CDemoCustomDataCallbacks>, IEquatable<CDemoCustomDataCallbacks>, IDeepCloneable<CDemoCustomDataCallbacks>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoCustomDataCallbacks](Divine.Protobufs.Dota2.CDemoCustomDataCallbacks.md)

#### Implements

IMessage<CDemoCustomDataCallbacks\>, 
[IEquatable<CDemoCustomDataCallbacks\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoCustomDataCallbacks\>, 
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
[EnumerableExtensions.In<CDemoCustomDataCallbacks\>\(CDemoCustomDataCallbacks, params CDemoCustomDataCallbacks\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks__ctor"></a> CDemoCustomDataCallbacks\(\)

```csharp
public CDemoCustomDataCallbacks()
```

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks__ctor_Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_"></a> CDemoCustomDataCallbacks\(CDemoCustomDataCallbacks\)

```csharp
public CDemoCustomDataCallbacks(CDemoCustomDataCallbacks other)
```

#### Parameters

`other` [CDemoCustomDataCallbacks](Divine.Protobufs.Dota2.CDemoCustomDataCallbacks.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_SaveIdFieldNumber"></a> SaveIdFieldNumber

```csharp
public const int SaveIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_Parser"></a> Parser

```csharp
public static MessageParser<CDemoCustomDataCallbacks> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoCustomDataCallbacks](Divine.Protobufs.Dota2.CDemoCustomDataCallbacks.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_SaveId"></a> SaveId

```csharp
public RepeatedField<string> SaveId { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_Clone"></a> Clone\(\)

```csharp
public CDemoCustomDataCallbacks Clone()
```

#### Returns

 [CDemoCustomDataCallbacks](Divine.Protobufs.Dota2.CDemoCustomDataCallbacks.md)

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_Equals_Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_"></a> Equals\(CDemoCustomDataCallbacks\)

```csharp
public bool Equals(CDemoCustomDataCallbacks other)
```

#### Parameters

`other` [CDemoCustomDataCallbacks](Divine.Protobufs.Dota2.CDemoCustomDataCallbacks.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_MergeFrom_Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_"></a> MergeFrom\(CDemoCustomDataCallbacks\)

```csharp
public void MergeFrom(CDemoCustomDataCallbacks other)
```

#### Parameters

`other` [CDemoCustomDataCallbacks](Divine.Protobufs.Dota2.CDemoCustomDataCallbacks.md)

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoCustomDataCallbacks_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

