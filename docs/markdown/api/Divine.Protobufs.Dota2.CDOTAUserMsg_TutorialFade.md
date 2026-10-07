# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade"></a> Class CDOTAUserMsg\_TutorialFade

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TutorialFade : IMessage<CDOTAUserMsg_TutorialFade>, IEquatable<CDOTAUserMsg_TutorialFade>, IDeepCloneable<CDOTAUserMsg_TutorialFade>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TutorialFade](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFade.md)

#### Implements

IMessage<CDOTAUserMsg\_TutorialFade\>, 
[IEquatable<CDOTAUserMsg\_TutorialFade\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TutorialFade\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TutorialFade\>\(CDOTAUserMsg\_TutorialFade, params CDOTAUserMsg\_TutorialFade\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade__ctor"></a> CDOTAUserMsg\_TutorialFade\(\)

```csharp
public CDOTAUserMsg_TutorialFade()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_"></a> CDOTAUserMsg\_TutorialFade\(CDOTAUserMsg\_TutorialFade\)

```csharp
public CDOTAUserMsg_TutorialFade(CDOTAUserMsg_TutorialFade other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialFade](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFade.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_TgtAlphaFieldNumber"></a> TgtAlphaFieldNumber

```csharp
public const int TgtAlphaFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_HasTgtAlpha"></a> HasTgtAlpha

```csharp
public bool HasTgtAlpha { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TutorialFade> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TutorialFade](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFade.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_TgtAlpha"></a> TgtAlpha

```csharp
public int TgtAlpha { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_ClearTgtAlpha"></a> ClearTgtAlpha\(\)

```csharp
public void ClearTgtAlpha()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TutorialFade Clone()
```

#### Returns

 [CDOTAUserMsg\_TutorialFade](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFade.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_"></a> Equals\(CDOTAUserMsg\_TutorialFade\)

```csharp
public bool Equals(CDOTAUserMsg_TutorialFade other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialFade](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFade.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_"></a> MergeFrom\(CDOTAUserMsg\_TutorialFade\)

```csharp
public void MergeFrom(CDOTAUserMsg_TutorialFade other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialFade](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialFade.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialFade_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

