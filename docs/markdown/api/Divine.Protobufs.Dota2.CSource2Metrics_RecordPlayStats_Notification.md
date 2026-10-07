# <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification"></a> Class CSource2Metrics\_RecordPlayStats\_Notification

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSource2Metrics_RecordPlayStats_Notification : IMessage<CSource2Metrics_RecordPlayStats_Notification>, IEquatable<CSource2Metrics_RecordPlayStats_Notification>, IDeepCloneable<CSource2Metrics_RecordPlayStats_Notification>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSource2Metrics\_RecordPlayStats\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_RecordPlayStats\_Notification.md)

#### Implements

IMessage<CSource2Metrics\_RecordPlayStats\_Notification\>, 
[IEquatable<CSource2Metrics\_RecordPlayStats\_Notification\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSource2Metrics\_RecordPlayStats\_Notification\>, 
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
[EnumerableExtensions.In<CSource2Metrics\_RecordPlayStats\_Notification\>\(CSource2Metrics\_RecordPlayStats\_Notification, params CSource2Metrics\_RecordPlayStats\_Notification\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification__ctor"></a> CSource2Metrics\_RecordPlayStats\_Notification\(\)

```csharp
public CSource2Metrics_RecordPlayStats_Notification()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification__ctor_Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_"></a> CSource2Metrics\_RecordPlayStats\_Notification\(CSource2Metrics\_RecordPlayStats\_Notification\)

```csharp
public CSource2Metrics_RecordPlayStats_Notification(CSource2Metrics_RecordPlayStats_Notification other)
```

#### Parameters

`other` [CSource2Metrics\_RecordPlayStats\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_RecordPlayStats\_Notification.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_RecordTypesFieldNumber"></a> RecordTypesFieldNumber

```csharp
public const int RecordTypesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_Parser"></a> Parser

```csharp
public static MessageParser<CSource2Metrics_RecordPlayStats_Notification> Parser { get; }
```

#### Property Value

 MessageParser<[CSource2Metrics\_RecordPlayStats\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_RecordPlayStats\_Notification.md)\>

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_RecordTypes"></a> RecordTypes

```csharp
public RepeatedField<CMsgSource2PlayStatsPackedRecordList> RecordTypes { get; }
```

#### Property Value

 RepeatedField<[CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_Clone"></a> Clone\(\)

```csharp
public CSource2Metrics_RecordPlayStats_Notification Clone()
```

#### Returns

 [CSource2Metrics\_RecordPlayStats\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_RecordPlayStats\_Notification.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_Equals_Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_"></a> Equals\(CSource2Metrics\_RecordPlayStats\_Notification\)

```csharp
public bool Equals(CSource2Metrics_RecordPlayStats_Notification other)
```

#### Parameters

`other` [CSource2Metrics\_RecordPlayStats\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_RecordPlayStats\_Notification.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_MergeFrom_Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_"></a> MergeFrom\(CSource2Metrics\_RecordPlayStats\_Notification\)

```csharp
public void MergeFrom(CSource2Metrics_RecordPlayStats_Notification other)
```

#### Parameters

`other` [CSource2Metrics\_RecordPlayStats\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_RecordPlayStats\_Notification.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_RecordPlayStats_Notification_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

