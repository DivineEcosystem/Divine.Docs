# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints"></a> Class CMsgDOTAGetEventPoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetEventPoints : IMessage<CMsgDOTAGetEventPoints>, IEquatable<CMsgDOTAGetEventPoints>, IDeepCloneable<CMsgDOTAGetEventPoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetEventPoints](Divine.Protobufs.Dota2.CMsgDOTAGetEventPoints.md)

#### Implements

IMessage<CMsgDOTAGetEventPoints\>, 
[IEquatable<CMsgDOTAGetEventPoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetEventPoints\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetEventPoints\>\(CMsgDOTAGetEventPoints, params CMsgDOTAGetEventPoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints__ctor"></a> CMsgDOTAGetEventPoints\(\)

```csharp
public CMsgDOTAGetEventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_"></a> CMsgDOTAGetEventPoints\(CMsgDOTAGetEventPoints\)

```csharp
public CMsgDOTAGetEventPoints(CMsgDOTAGetEventPoints other)
```

#### Parameters

`other` [CMsgDOTAGetEventPoints](Divine.Protobufs.Dota2.CMsgDOTAGetEventPoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetEventPoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetEventPoints](Divine.Protobufs.Dota2.CMsgDOTAGetEventPoints.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetEventPoints Clone()
```

#### Returns

 [CMsgDOTAGetEventPoints](Divine.Protobufs.Dota2.CMsgDOTAGetEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_"></a> Equals\(CMsgDOTAGetEventPoints\)

```csharp
public bool Equals(CMsgDOTAGetEventPoints other)
```

#### Parameters

`other` [CMsgDOTAGetEventPoints](Divine.Protobufs.Dota2.CMsgDOTAGetEventPoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_"></a> MergeFrom\(CMsgDOTAGetEventPoints\)

```csharp
public void MergeFrom(CMsgDOTAGetEventPoints other)
```

#### Parameters

`other` [CMsgDOTAGetEventPoints](Divine.Protobufs.Dota2.CMsgDOTAGetEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

