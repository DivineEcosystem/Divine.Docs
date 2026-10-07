# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant"></a> Class CDOTAClientMsg\_SetCavernMapVariant

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SetCavernMapVariant : IMessage<CDOTAClientMsg_SetCavernMapVariant>, IEquatable<CDOTAClientMsg_SetCavernMapVariant>, IDeepCloneable<CDOTAClientMsg_SetCavernMapVariant>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SetCavernMapVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetCavernMapVariant.md)

#### Implements

IMessage<CDOTAClientMsg\_SetCavernMapVariant\>, 
[IEquatable<CDOTAClientMsg\_SetCavernMapVariant\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SetCavernMapVariant\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SetCavernMapVariant\>\(CDOTAClientMsg\_SetCavernMapVariant, params CDOTAClientMsg\_SetCavernMapVariant\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant__ctor"></a> CDOTAClientMsg\_SetCavernMapVariant\(\)

```csharp
public CDOTAClientMsg_SetCavernMapVariant()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_"></a> CDOTAClientMsg\_SetCavernMapVariant\(CDOTAClientMsg\_SetCavernMapVariant\)

```csharp
public CDOTAClientMsg_SetCavernMapVariant(CDOTAClientMsg_SetCavernMapVariant other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetCavernMapVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetCavernMapVariant.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_MapVariantFieldNumber"></a> MapVariantFieldNumber

```csharp
public const int MapVariantFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_HasMapVariant"></a> HasMapVariant

```csharp
public bool HasMapVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_MapVariant"></a> MapVariant

```csharp
public uint MapVariant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SetCavernMapVariant> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SetCavernMapVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetCavernMapVariant.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_ClearMapVariant"></a> ClearMapVariant\(\)

```csharp
public void ClearMapVariant()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SetCavernMapVariant Clone()
```

#### Returns

 [CDOTAClientMsg\_SetCavernMapVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetCavernMapVariant.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_"></a> Equals\(CDOTAClientMsg\_SetCavernMapVariant\)

```csharp
public bool Equals(CDOTAClientMsg_SetCavernMapVariant other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetCavernMapVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetCavernMapVariant.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_"></a> MergeFrom\(CDOTAClientMsg\_SetCavernMapVariant\)

```csharp
public void MergeFrom(CDOTAClientMsg_SetCavernMapVariant other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetCavernMapVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetCavernMapVariant.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetCavernMapVariant_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

