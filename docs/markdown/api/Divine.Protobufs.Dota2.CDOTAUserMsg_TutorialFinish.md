# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish"></a> Class CDOTAUserMsg\_TutorialFinish

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TutorialFinish : IMessage<CDOTAUserMsg_TutorialFinish>, IEquatable<CDOTAUserMsg_TutorialFinish>, IDeepCloneable<CDOTAUserMsg_TutorialFinish>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TutorialFinish](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFinish.md)

#### Implements

IMessage<CDOTAUserMsg\_TutorialFinish\>, 
[IEquatable<CDOTAUserMsg\_TutorialFinish\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TutorialFinish\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TutorialFinish\>\(CDOTAUserMsg\_TutorialFinish, params CDOTAUserMsg\_TutorialFinish\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish__ctor"></a> CDOTAUserMsg\_TutorialFinish\(\)

```csharp
public CDOTAUserMsg_TutorialFinish()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_"></a> CDOTAUserMsg\_TutorialFinish\(CDOTAUserMsg\_TutorialFinish\)

```csharp
public CDOTAUserMsg_TutorialFinish(CDOTAUserMsg_TutorialFinish other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialFinish](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFinish.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_BodyFieldNumber"></a> BodyFieldNumber

```csharp
public const int BodyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_EmblemFieldNumber"></a> EmblemFieldNumber

```csharp
public const int EmblemFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_HeadingFieldNumber"></a> HeadingFieldNumber

```csharp
public const int HeadingFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Body"></a> Body

```csharp
public string Body { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Emblem"></a> Emblem

```csharp
public string Emblem { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_HasBody"></a> HasBody

```csharp
public bool HasBody { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_HasEmblem"></a> HasEmblem

```csharp
public bool HasEmblem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_HasHeading"></a> HasHeading

```csharp
public bool HasHeading { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Heading"></a> Heading

```csharp
public string Heading { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TutorialFinish> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TutorialFinish](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFinish.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_ClearBody"></a> ClearBody\(\)

```csharp
public void ClearBody()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_ClearEmblem"></a> ClearEmblem\(\)

```csharp
public void ClearEmblem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_ClearHeading"></a> ClearHeading\(\)

```csharp
public void ClearHeading()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TutorialFinish Clone()
```

#### Returns

 [CDOTAUserMsg\_TutorialFinish](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFinish.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_"></a> Equals\(CDOTAUserMsg\_TutorialFinish\)

```csharp
public bool Equals(CDOTAUserMsg_TutorialFinish other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialFinish](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFinish.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_"></a> MergeFrom\(CDOTAUserMsg\_TutorialFinish\)

```csharp
public void MergeFrom(CDOTAUserMsg_TutorialFinish other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialFinish](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFinish.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFinish_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

