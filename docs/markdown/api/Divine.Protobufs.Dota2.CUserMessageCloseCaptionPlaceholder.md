# <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder"></a> Class CUserMessageCloseCaptionPlaceholder

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageCloseCaptionPlaceholder : IMessage<CUserMessageCloseCaptionPlaceholder>, IEquatable<CUserMessageCloseCaptionPlaceholder>, IDeepCloneable<CUserMessageCloseCaptionPlaceholder>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageCloseCaptionPlaceholder](Divine.Protobufs.Dota2.CUserMessageCloseCaptionPlaceholder.md)

#### Implements

IMessage<CUserMessageCloseCaptionPlaceholder\>, 
[IEquatable<CUserMessageCloseCaptionPlaceholder\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageCloseCaptionPlaceholder\>, 
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
[EnumerableExtensions.In<CUserMessageCloseCaptionPlaceholder\>\(CUserMessageCloseCaptionPlaceholder, params CUserMessageCloseCaptionPlaceholder\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder__ctor"></a> CUserMessageCloseCaptionPlaceholder\(\)

```csharp
public CUserMessageCloseCaptionPlaceholder()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder__ctor_Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_"></a> CUserMessageCloseCaptionPlaceholder\(CUserMessageCloseCaptionPlaceholder\)

```csharp
public CUserMessageCloseCaptionPlaceholder(CUserMessageCloseCaptionPlaceholder other)
```

#### Parameters

`other` [CUserMessageCloseCaptionPlaceholder](Divine.Protobufs.Dota2.CUserMessageCloseCaptionPlaceholder.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_EntIndexFieldNumber"></a> EntIndexFieldNumber

```csharp
public const int EntIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_FromPlayerFieldNumber"></a> FromPlayerFieldNumber

```csharp
public const int FromPlayerFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_StringFieldNumber"></a> StringFieldNumber

```csharp
public const int StringFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_EntIndex"></a> EntIndex

```csharp
public int EntIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_FromPlayer"></a> FromPlayer

```csharp
public bool FromPlayer { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_HasEntIndex"></a> HasEntIndex

```csharp
public bool HasEntIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_HasFromPlayer"></a> HasFromPlayer

```csharp
public bool HasFromPlayer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_HasString"></a> HasString

```csharp
public bool HasString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageCloseCaptionPlaceholder> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageCloseCaptionPlaceholder](Divine.Protobufs.Dota2.CUserMessageCloseCaptionPlaceholder.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_String"></a> String

```csharp
public string String { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_ClearEntIndex"></a> ClearEntIndex\(\)

```csharp
public void ClearEntIndex()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_ClearFromPlayer"></a> ClearFromPlayer\(\)

```csharp
public void ClearFromPlayer()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_ClearString"></a> ClearString\(\)

```csharp
public void ClearString()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_Clone"></a> Clone\(\)

```csharp
public CUserMessageCloseCaptionPlaceholder Clone()
```

#### Returns

 [CUserMessageCloseCaptionPlaceholder](Divine.Protobufs.Dota2.CUserMessageCloseCaptionPlaceholder.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_Equals_Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_"></a> Equals\(CUserMessageCloseCaptionPlaceholder\)

```csharp
public bool Equals(CUserMessageCloseCaptionPlaceholder other)
```

#### Parameters

`other` [CUserMessageCloseCaptionPlaceholder](Divine.Protobufs.Dota2.CUserMessageCloseCaptionPlaceholder.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_MergeFrom_Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_"></a> MergeFrom\(CUserMessageCloseCaptionPlaceholder\)

```csharp
public void MergeFrom(CUserMessageCloseCaptionPlaceholder other)
```

#### Parameters

`other` [CUserMessageCloseCaptionPlaceholder](Divine.Protobufs.Dota2.CUserMessageCloseCaptionPlaceholder.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageCloseCaptionPlaceholder_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

