# <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing"></a> Class CDOTAMsg\_LocationPing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMsg_LocationPing : IMessage<CDOTAMsg_LocationPing>, IEquatable<CDOTAMsg_LocationPing>, IDeepCloneable<CDOTAMsg_LocationPing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMsg\_LocationPing](Divine.Protobufs.Dota2.CDOTAMsg\_LocationPing.md)

#### Implements

IMessage<CDOTAMsg\_LocationPing\>, 
[IEquatable<CDOTAMsg\_LocationPing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMsg\_LocationPing\>, 
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
[EnumerableExtensions.In<CDOTAMsg\_LocationPing\>\(CDOTAMsg\_LocationPing, params CDOTAMsg\_LocationPing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing__ctor"></a> CDOTAMsg\_LocationPing\(\)

```csharp
public CDOTAMsg_LocationPing()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing__ctor_Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_"></a> CDOTAMsg\_LocationPing\(CDOTAMsg\_LocationPing\)

```csharp
public CDOTAMsg_LocationPing(CDOTAMsg_LocationPing other)
```

#### Parameters

`other` [CDOTAMsg\_LocationPing](Divine.Protobufs.Dota2.CDOTAMsg\_LocationPing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_DirectPingFieldNumber"></a> DirectPingFieldNumber

```csharp
public const int DirectPingFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_PingSourceFieldNumber"></a> PingSourceFieldNumber

```csharp
public const int PingSourceFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_TargetFieldNumber"></a> TargetFieldNumber

```csharp
public const int TargetFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_WaypointPathFieldNumber"></a> WaypointPathFieldNumber

```csharp
public const int WaypointPathFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_DirectPing"></a> DirectPing

```csharp
public bool DirectPing { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_HasDirectPing"></a> HasDirectPing

```csharp
public bool HasDirectPing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_HasPingSource"></a> HasPingSource

```csharp
public bool HasPingSource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_HasTarget"></a> HasTarget

```csharp
public bool HasTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMsg_LocationPing> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMsg\_LocationPing](Divine.Protobufs.Dota2.CDOTAMsg\_LocationPing.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_PingSource"></a> PingSource

```csharp
public EPingSource PingSource { get; set; }
```

#### Property Value

 [EPingSource](Divine.Protobufs.Dota2.EPingSource.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_Target"></a> Target

```csharp
public int Target { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_WaypointPath"></a> WaypointPath

```csharp
public CDOTAMsg_PingWaypointPath WaypointPath { get; set; }
```

#### Property Value

 [CDOTAMsg\_PingWaypointPath](Divine.Protobufs.Dota2.CDOTAMsg\_PingWaypointPath.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_X"></a> X

```csharp
public int X { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_Y"></a> Y

```csharp
public int Y { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_ClearDirectPing"></a> ClearDirectPing\(\)

```csharp
public void ClearDirectPing()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_ClearPingSource"></a> ClearPingSource\(\)

```csharp
public void ClearPingSource()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_ClearTarget"></a> ClearTarget\(\)

```csharp
public void ClearTarget()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_Clone"></a> Clone\(\)

```csharp
public CDOTAMsg_LocationPing Clone()
```

#### Returns

 [CDOTAMsg\_LocationPing](Divine.Protobufs.Dota2.CDOTAMsg\_LocationPing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_Equals_Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_"></a> Equals\(CDOTAMsg\_LocationPing\)

```csharp
public bool Equals(CDOTAMsg_LocationPing other)
```

#### Parameters

`other` [CDOTAMsg\_LocationPing](Divine.Protobufs.Dota2.CDOTAMsg\_LocationPing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_MergeFrom_Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_"></a> MergeFrom\(CDOTAMsg\_LocationPing\)

```csharp
public void MergeFrom(CDOTAMsg_LocationPing other)
```

#### Parameters

`other` [CDOTAMsg\_LocationPing](Divine.Protobufs.Dota2.CDOTAMsg\_LocationPing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_LocationPing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

