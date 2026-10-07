# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup"></a> Class CDOTAUserMsg\_SendRoshanPopup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SendRoshanPopup : IMessage<CDOTAUserMsg_SendRoshanPopup>, IEquatable<CDOTAUserMsg_SendRoshanPopup>, IDeepCloneable<CDOTAUserMsg_SendRoshanPopup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SendRoshanPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanPopup.md)

#### Implements

IMessage<CDOTAUserMsg\_SendRoshanPopup\>, 
[IEquatable<CDOTAUserMsg\_SendRoshanPopup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SendRoshanPopup\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SendRoshanPopup\>\(CDOTAUserMsg\_SendRoshanPopup, params CDOTAUserMsg\_SendRoshanPopup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup__ctor"></a> CDOTAUserMsg\_SendRoshanPopup\(\)

```csharp
public CDOTAUserMsg_SendRoshanPopup()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_"></a> CDOTAUserMsg\_SendRoshanPopup\(CDOTAUserMsg\_SendRoshanPopup\)

```csharp
public CDOTAUserMsg_SendRoshanPopup(CDOTAUserMsg_SendRoshanPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendRoshanPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanPopup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_GametimeFieldNumber"></a> GametimeFieldNumber

```csharp
public const int GametimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_ReclaimedFieldNumber"></a> ReclaimedFieldNumber

```csharp
public const int ReclaimedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_Gametime"></a> Gametime

```csharp
public int Gametime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_HasGametime"></a> HasGametime

```csharp
public bool HasGametime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_HasReclaimed"></a> HasReclaimed

```csharp
public bool HasReclaimed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SendRoshanPopup> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SendRoshanPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanPopup.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_Reclaimed"></a> Reclaimed

```csharp
public bool Reclaimed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_ClearGametime"></a> ClearGametime\(\)

```csharp
public void ClearGametime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_ClearReclaimed"></a> ClearReclaimed\(\)

```csharp
public void ClearReclaimed()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SendRoshanPopup Clone()
```

#### Returns

 [CDOTAUserMsg\_SendRoshanPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanPopup.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_"></a> Equals\(CDOTAUserMsg\_SendRoshanPopup\)

```csharp
public bool Equals(CDOTAUserMsg_SendRoshanPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendRoshanPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanPopup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_"></a> MergeFrom\(CDOTAUserMsg\_SendRoshanPopup\)

```csharp
public void MergeFrom(CDOTAUserMsg_SendRoshanPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendRoshanPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanPopup.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanPopup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

