# <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy"></a> Class CMsgDOTASetProfilePrivacy

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASetProfilePrivacy : IMessage<CMsgDOTASetProfilePrivacy>, IEquatable<CMsgDOTASetProfilePrivacy>, IDeepCloneable<CMsgDOTASetProfilePrivacy>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASetProfilePrivacy](Divine.Protobufs.Dota2.CMsgDOTASetProfilePrivacy.md)

#### Implements

IMessage<CMsgDOTASetProfilePrivacy\>, 
[IEquatable<CMsgDOTASetProfilePrivacy\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASetProfilePrivacy\>, 
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
[EnumerableExtensions.In<CMsgDOTASetProfilePrivacy\>\(CMsgDOTASetProfilePrivacy, params CMsgDOTASetProfilePrivacy\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy__ctor"></a> CMsgDOTASetProfilePrivacy\(\)

```csharp
public CMsgDOTASetProfilePrivacy()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy__ctor_Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_"></a> CMsgDOTASetProfilePrivacy\(CMsgDOTASetProfilePrivacy\)

```csharp
public CMsgDOTASetProfilePrivacy(CMsgDOTASetProfilePrivacy other)
```

#### Parameters

`other` [CMsgDOTASetProfilePrivacy](Divine.Protobufs.Dota2.CMsgDOTASetProfilePrivacy.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_ProfilePrivateFieldNumber"></a> ProfilePrivateFieldNumber

```csharp
public const int ProfilePrivateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_HasProfilePrivate"></a> HasProfilePrivate

```csharp
public bool HasProfilePrivate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASetProfilePrivacy> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASetProfilePrivacy](Divine.Protobufs.Dota2.CMsgDOTASetProfilePrivacy.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_ProfilePrivate"></a> ProfilePrivate

```csharp
public bool ProfilePrivate { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_ClearProfilePrivate"></a> ClearProfilePrivate\(\)

```csharp
public void ClearProfilePrivate()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASetProfilePrivacy Clone()
```

#### Returns

 [CMsgDOTASetProfilePrivacy](Divine.Protobufs.Dota2.CMsgDOTASetProfilePrivacy.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_Equals_Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_"></a> Equals\(CMsgDOTASetProfilePrivacy\)

```csharp
public bool Equals(CMsgDOTASetProfilePrivacy other)
```

#### Parameters

`other` [CMsgDOTASetProfilePrivacy](Divine.Protobufs.Dota2.CMsgDOTASetProfilePrivacy.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_"></a> MergeFrom\(CMsgDOTASetProfilePrivacy\)

```csharp
public void MergeFrom(CMsgDOTASetProfilePrivacy other)
```

#### Parameters

`other` [CMsgDOTASetProfilePrivacy](Divine.Protobufs.Dota2.CMsgDOTASetProfilePrivacy.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetProfilePrivacy_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

