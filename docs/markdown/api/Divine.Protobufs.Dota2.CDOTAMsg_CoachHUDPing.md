# <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing"></a> Class CDOTAMsg\_CoachHUDPing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMsg_CoachHUDPing : IMessage<CDOTAMsg_CoachHUDPing>, IEquatable<CDOTAMsg_CoachHUDPing>, IDeepCloneable<CDOTAMsg_CoachHUDPing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMsg\_CoachHUDPing](Divine.Protobufs.Dota2.CDOTAMsg\_CoachHUDPing.md)

#### Implements

IMessage<CDOTAMsg\_CoachHUDPing\>, 
[IEquatable<CDOTAMsg\_CoachHUDPing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMsg\_CoachHUDPing\>, 
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
[EnumerableExtensions.In<CDOTAMsg\_CoachHUDPing\>\(CDOTAMsg\_CoachHUDPing, params CDOTAMsg\_CoachHUDPing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing__ctor"></a> CDOTAMsg\_CoachHUDPing\(\)

```csharp
public CDOTAMsg_CoachHUDPing()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing__ctor_Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_"></a> CDOTAMsg\_CoachHUDPing\(CDOTAMsg\_CoachHUDPing\)

```csharp
public CDOTAMsg_CoachHUDPing(CDOTAMsg_CoachHUDPing other)
```

#### Parameters

`other` [CDOTAMsg\_CoachHUDPing](Divine.Protobufs.Dota2.CDOTAMsg\_CoachHUDPing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_TgtpathFieldNumber"></a> TgtpathFieldNumber

```csharp
public const int TgtpathFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_HasTgtpath"></a> HasTgtpath

```csharp
public bool HasTgtpath { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMsg_CoachHUDPing> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMsg\_CoachHUDPing](Divine.Protobufs.Dota2.CDOTAMsg\_CoachHUDPing.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_Tgtpath"></a> Tgtpath

```csharp
public string Tgtpath { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_X"></a> X

```csharp
public uint X { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_Y"></a> Y

```csharp
public uint Y { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_ClearTgtpath"></a> ClearTgtpath\(\)

```csharp
public void ClearTgtpath()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_Clone"></a> Clone\(\)

```csharp
public CDOTAMsg_CoachHUDPing Clone()
```

#### Returns

 [CDOTAMsg\_CoachHUDPing](Divine.Protobufs.Dota2.CDOTAMsg\_CoachHUDPing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_Equals_Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_"></a> Equals\(CDOTAMsg\_CoachHUDPing\)

```csharp
public bool Equals(CDOTAMsg_CoachHUDPing other)
```

#### Parameters

`other` [CDOTAMsg\_CoachHUDPing](Divine.Protobufs.Dota2.CDOTAMsg\_CoachHUDPing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_MergeFrom_Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_"></a> MergeFrom\(CDOTAMsg\_CoachHUDPing\)

```csharp
public void MergeFrom(CDOTAMsg_CoachHUDPing other)
```

#### Parameters

`other` [CDOTAMsg\_CoachHUDPing](Divine.Protobufs.Dota2.CDOTAMsg\_CoachHUDPing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_CoachHUDPing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

