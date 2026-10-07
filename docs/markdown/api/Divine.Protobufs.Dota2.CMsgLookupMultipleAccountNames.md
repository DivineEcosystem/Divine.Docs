# <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames"></a> Class CMsgLookupMultipleAccountNames

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLookupMultipleAccountNames : IMessage<CMsgLookupMultipleAccountNames>, IEquatable<CMsgLookupMultipleAccountNames>, IDeepCloneable<CMsgLookupMultipleAccountNames>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLookupMultipleAccountNames](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNames.md)

#### Implements

IMessage<CMsgLookupMultipleAccountNames\>, 
[IEquatable<CMsgLookupMultipleAccountNames\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLookupMultipleAccountNames\>, 
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
[EnumerableExtensions.In<CMsgLookupMultipleAccountNames\>\(CMsgLookupMultipleAccountNames, params CMsgLookupMultipleAccountNames\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames__ctor"></a> CMsgLookupMultipleAccountNames\(\)

```csharp
public CMsgLookupMultipleAccountNames()
```

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames__ctor_Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_"></a> CMsgLookupMultipleAccountNames\(CMsgLookupMultipleAccountNames\)

```csharp
public CMsgLookupMultipleAccountNames(CMsgLookupMultipleAccountNames other)
```

#### Parameters

`other` [CMsgLookupMultipleAccountNames](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNames.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_AccountidsFieldNumber"></a> AccountidsFieldNumber

```csharp
public const int AccountidsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_Accountids"></a> Accountids

```csharp
public RepeatedField<uint> Accountids { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLookupMultipleAccountNames> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLookupMultipleAccountNames](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNames.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_Clone"></a> Clone\(\)

```csharp
public CMsgLookupMultipleAccountNames Clone()
```

#### Returns

 [CMsgLookupMultipleAccountNames](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNames.md)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_Equals_Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_"></a> Equals\(CMsgLookupMultipleAccountNames\)

```csharp
public bool Equals(CMsgLookupMultipleAccountNames other)
```

#### Parameters

`other` [CMsgLookupMultipleAccountNames](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNames.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_MergeFrom_Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_"></a> MergeFrom\(CMsgLookupMultipleAccountNames\)

```csharp
public void MergeFrom(CMsgLookupMultipleAccountNames other)
```

#### Parameters

`other` [CMsgLookupMultipleAccountNames](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNames.md)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNames_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

