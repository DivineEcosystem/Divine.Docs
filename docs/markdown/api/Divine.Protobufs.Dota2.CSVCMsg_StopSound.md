# <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound"></a> Class CSVCMsg\_StopSound

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_StopSound : IMessage<CSVCMsg_StopSound>, IEquatable<CSVCMsg_StopSound>, IDeepCloneable<CSVCMsg_StopSound>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_StopSound](Divine.Protobufs.Dota2.CSVCMsg\_StopSound.md)

#### Implements

IMessage<CSVCMsg\_StopSound\>, 
[IEquatable<CSVCMsg\_StopSound\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_StopSound\>, 
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
[EnumerableExtensions.In<CSVCMsg\_StopSound\>\(CSVCMsg\_StopSound, params CSVCMsg\_StopSound\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound__ctor"></a> CSVCMsg\_StopSound\(\)

```csharp
public CSVCMsg_StopSound()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound__ctor_Divine_Protobufs_Dota2_CSVCMsg_StopSound_"></a> CSVCMsg\_StopSound\(CSVCMsg\_StopSound\)

```csharp
public CSVCMsg_StopSound(CSVCMsg_StopSound other)
```

#### Parameters

`other` [CSVCMsg\_StopSound](Divine.Protobufs.Dota2.CSVCMsg\_StopSound.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_GuidFieldNumber"></a> GuidFieldNumber

```csharp
public const int GuidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_Guid"></a> Guid

```csharp
public uint Guid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_HasGuid"></a> HasGuid

```csharp
public bool HasGuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_StopSound> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_StopSound](Divine.Protobufs.Dota2.CSVCMsg\_StopSound.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_ClearGuid"></a> ClearGuid\(\)

```csharp
public void ClearGuid()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_StopSound Clone()
```

#### Returns

 [CSVCMsg\_StopSound](Divine.Protobufs.Dota2.CSVCMsg\_StopSound.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_Equals_Divine_Protobufs_Dota2_CSVCMsg_StopSound_"></a> Equals\(CSVCMsg\_StopSound\)

```csharp
public bool Equals(CSVCMsg_StopSound other)
```

#### Parameters

`other` [CSVCMsg\_StopSound](Divine.Protobufs.Dota2.CSVCMsg\_StopSound.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_StopSound_"></a> MergeFrom\(CSVCMsg\_StopSound\)

```csharp
public void MergeFrom(CSVCMsg_StopSound other)
```

#### Parameters

`other` [CSVCMsg\_StopSound](Divine.Protobufs.Dota2.CSVCMsg\_StopSound.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_StopSound_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

