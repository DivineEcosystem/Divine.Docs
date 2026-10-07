# <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate"></a> Class CMsgGCToClientWageringUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientWageringUpdate : IMessage<CMsgGCToClientWageringUpdate>, IEquatable<CMsgGCToClientWageringUpdate>, IDeepCloneable<CMsgGCToClientWageringUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientWageringUpdate](Divine.Protobufs.Dota2.CMsgGCToClientWageringUpdate.md)

#### Implements

IMessage<CMsgGCToClientWageringUpdate\>, 
[IEquatable<CMsgGCToClientWageringUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientWageringUpdate\>, 
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
[EnumerableExtensions.In<CMsgGCToClientWageringUpdate\>\(CMsgGCToClientWageringUpdate, params CMsgGCToClientWageringUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate__ctor"></a> CMsgGCToClientWageringUpdate\(\)

```csharp
public CMsgGCToClientWageringUpdate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate__ctor_Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_"></a> CMsgGCToClientWageringUpdate\(CMsgGCToClientWageringUpdate\)

```csharp
public CMsgGCToClientWageringUpdate(CMsgGCToClientWageringUpdate other)
```

#### Parameters

`other` [CMsgGCToClientWageringUpdate](Divine.Protobufs.Dota2.CMsgGCToClientWageringUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_WageringInfoFieldNumber"></a> WageringInfoFieldNumber

```csharp
public const int WageringInfoFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientWageringUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientWageringUpdate](Divine.Protobufs.Dota2.CMsgGCToClientWageringUpdate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_WageringInfo"></a> WageringInfo

```csharp
public CMsgGCToClientWageringResponse WageringInfo { get; set; }
```

#### Property Value

 [CMsgGCToClientWageringResponse](Divine.Protobufs.Dota2.CMsgGCToClientWageringResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientWageringUpdate Clone()
```

#### Returns

 [CMsgGCToClientWageringUpdate](Divine.Protobufs.Dota2.CMsgGCToClientWageringUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_Equals_Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_"></a> Equals\(CMsgGCToClientWageringUpdate\)

```csharp
public bool Equals(CMsgGCToClientWageringUpdate other)
```

#### Parameters

`other` [CMsgGCToClientWageringUpdate](Divine.Protobufs.Dota2.CMsgGCToClientWageringUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_"></a> MergeFrom\(CMsgGCToClientWageringUpdate\)

```csharp
public void MergeFrom(CMsgGCToClientWageringUpdate other)
```

#### Parameters

`other` [CMsgGCToClientWageringUpdate](Divine.Protobufs.Dota2.CMsgGCToClientWageringUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientWageringUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

