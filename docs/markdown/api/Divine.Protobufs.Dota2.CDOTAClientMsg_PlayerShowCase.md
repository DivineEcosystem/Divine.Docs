# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase"></a> Class CDOTAClientMsg\_PlayerShowCase

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_PlayerShowCase : IMessage<CDOTAClientMsg_PlayerShowCase>, IEquatable<CDOTAClientMsg_PlayerShowCase>, IDeepCloneable<CDOTAClientMsg_PlayerShowCase>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_PlayerShowCase](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerShowCase.md)

#### Implements

IMessage<CDOTAClientMsg\_PlayerShowCase\>, 
[IEquatable<CDOTAClientMsg\_PlayerShowCase\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_PlayerShowCase\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_PlayerShowCase\>\(CDOTAClientMsg\_PlayerShowCase, params CDOTAClientMsg\_PlayerShowCase\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase__ctor"></a> CDOTAClientMsg\_PlayerShowCase\(\)

```csharp
public CDOTAClientMsg_PlayerShowCase()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_"></a> CDOTAClientMsg\_PlayerShowCase\(CDOTAClientMsg\_PlayerShowCase\)

```csharp
public CDOTAClientMsg_PlayerShowCase(CDOTAClientMsg_PlayerShowCase other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerShowCase](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerShowCase.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_ShowcaseFieldNumber"></a> ShowcaseFieldNumber

```csharp
public const int ShowcaseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_HasShowcase"></a> HasShowcase

```csharp
public bool HasShowcase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_PlayerShowCase> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_PlayerShowCase](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerShowCase.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_Showcase"></a> Showcase

```csharp
public bool Showcase { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_ClearShowcase"></a> ClearShowcase\(\)

```csharp
public void ClearShowcase()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_PlayerShowCase Clone()
```

#### Returns

 [CDOTAClientMsg\_PlayerShowCase](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerShowCase.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_"></a> Equals\(CDOTAClientMsg\_PlayerShowCase\)

```csharp
public bool Equals(CDOTAClientMsg_PlayerShowCase other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerShowCase](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerShowCase.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_"></a> MergeFrom\(CDOTAClientMsg\_PlayerShowCase\)

```csharp
public void MergeFrom(CDOTAClientMsg_PlayerShowCase other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerShowCase](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerShowCase.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerShowCase_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

