# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging"></a> Class CDOTAUserMsg\_HighFiveLeftHanging

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_HighFiveLeftHanging : IMessage<CDOTAUserMsg_HighFiveLeftHanging>, IEquatable<CDOTAUserMsg_HighFiveLeftHanging>, IDeepCloneable<CDOTAUserMsg_HighFiveLeftHanging>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_HighFiveLeftHanging](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveLeftHanging.md)

#### Implements

IMessage<CDOTAUserMsg\_HighFiveLeftHanging\>, 
[IEquatable<CDOTAUserMsg\_HighFiveLeftHanging\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_HighFiveLeftHanging\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_HighFiveLeftHanging\>\(CDOTAUserMsg\_HighFiveLeftHanging, params CDOTAUserMsg\_HighFiveLeftHanging\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging__ctor"></a> CDOTAUserMsg\_HighFiveLeftHanging\(\)

```csharp
public CDOTAUserMsg_HighFiveLeftHanging()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_"></a> CDOTAUserMsg\_HighFiveLeftHanging\(CDOTAUserMsg\_HighFiveLeftHanging\)

```csharp
public CDOTAUserMsg_HighFiveLeftHanging(CDOTAUserMsg_HighFiveLeftHanging other)
```

#### Parameters

`other` [CDOTAUserMsg\_HighFiveLeftHanging](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveLeftHanging.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_HighFiveLeftHanging> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_HighFiveLeftHanging](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveLeftHanging.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_HighFiveLeftHanging Clone()
```

#### Returns

 [CDOTAUserMsg\_HighFiveLeftHanging](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveLeftHanging.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_"></a> Equals\(CDOTAUserMsg\_HighFiveLeftHanging\)

```csharp
public bool Equals(CDOTAUserMsg_HighFiveLeftHanging other)
```

#### Parameters

`other` [CDOTAUserMsg\_HighFiveLeftHanging](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveLeftHanging.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_"></a> MergeFrom\(CDOTAUserMsg\_HighFiveLeftHanging\)

```csharp
public void MergeFrom(CDOTAUserMsg_HighFiveLeftHanging other)
```

#### Parameters

`other` [CDOTAUserMsg\_HighFiveLeftHanging](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveLeftHanging.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveLeftHanging_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

