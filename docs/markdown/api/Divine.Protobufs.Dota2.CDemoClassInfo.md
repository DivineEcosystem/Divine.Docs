# <a id="Divine_Protobufs_Dota2_CDemoClassInfo"></a> Class CDemoClassInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoClassInfo : IMessage<CDemoClassInfo>, IEquatable<CDemoClassInfo>, IDeepCloneable<CDemoClassInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoClassInfo](Divine.Protobufs.Dota2.CDemoClassInfo.md)

#### Implements

IMessage<CDemoClassInfo\>, 
[IEquatable<CDemoClassInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoClassInfo\>, 
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
[EnumerableExtensions.In<CDemoClassInfo\>\(CDemoClassInfo, params CDemoClassInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo__ctor"></a> CDemoClassInfo\(\)

```csharp
public CDemoClassInfo()
```

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo__ctor_Divine_Protobufs_Dota2_CDemoClassInfo_"></a> CDemoClassInfo\(CDemoClassInfo\)

```csharp
public CDemoClassInfo(CDemoClassInfo other)
```

#### Parameters

`other` [CDemoClassInfo](Divine.Protobufs.Dota2.CDemoClassInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_ClassesFieldNumber"></a> ClassesFieldNumber

```csharp
public const int ClassesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_Classes"></a> Classes

```csharp
public RepeatedField<CDemoClassInfo.Types.class_t> Classes { get; }
```

#### Property Value

 RepeatedField<[CDemoClassInfo](Divine.Protobufs.Dota2.CDemoClassInfo.md).[Types](Divine.Protobufs.Dota2.CDemoClassInfo.Types.md).[class\_t](Divine.Protobufs.Dota2.CDemoClassInfo.Types.class\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_Parser"></a> Parser

```csharp
public static MessageParser<CDemoClassInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoClassInfo](Divine.Protobufs.Dota2.CDemoClassInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_Clone"></a> Clone\(\)

```csharp
public CDemoClassInfo Clone()
```

#### Returns

 [CDemoClassInfo](Divine.Protobufs.Dota2.CDemoClassInfo.md)

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_Equals_Divine_Protobufs_Dota2_CDemoClassInfo_"></a> Equals\(CDemoClassInfo\)

```csharp
public bool Equals(CDemoClassInfo other)
```

#### Parameters

`other` [CDemoClassInfo](Divine.Protobufs.Dota2.CDemoClassInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_MergeFrom_Divine_Protobufs_Dota2_CDemoClassInfo_"></a> MergeFrom\(CDemoClassInfo\)

```csharp
public void MergeFrom(CDemoClassInfo other)
```

#### Parameters

`other` [CDemoClassInfo](Divine.Protobufs.Dota2.CDemoClassInfo.md)

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoClassInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

