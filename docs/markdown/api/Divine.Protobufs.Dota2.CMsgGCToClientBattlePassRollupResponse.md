# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse"></a> Class CMsgGCToClientBattlePassRollupResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollupResponse : IMessage<CMsgGCToClientBattlePassRollupResponse>, IEquatable<CMsgGCToClientBattlePassRollupResponse>, IDeepCloneable<CMsgGCToClientBattlePassRollupResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollupResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupResponse.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollupResponse\>, 
[IEquatable<CMsgGCToClientBattlePassRollupResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollupResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollupResponse\>\(CMsgGCToClientBattlePassRollupResponse, params CMsgGCToClientBattlePassRollupResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse__ctor"></a> CMsgGCToClientBattlePassRollupResponse\(\)

```csharp
public CMsgGCToClientBattlePassRollupResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_"></a> CMsgGCToClientBattlePassRollupResponse\(CMsgGCToClientBattlePassRollupResponse\)

```csharp
public CMsgGCToClientBattlePassRollupResponse(CMsgGCToClientBattlePassRollupResponse other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventFall2016FieldNumber"></a> EventFall2016FieldNumber

```csharp
public const int EventFall2016FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi10FieldNumber"></a> EventTi10FieldNumber

```csharp
public const int EventTi10FieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi6FieldNumber"></a> EventTi6FieldNumber

```csharp
public const int EventTi6FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi7FieldNumber"></a> EventTi7FieldNumber

```csharp
public const int EventTi7FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi8FieldNumber"></a> EventTi8FieldNumber

```csharp
public const int EventTi8FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi9FieldNumber"></a> EventTi9FieldNumber

```csharp
public const int EventTi9FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventWinter2017FieldNumber"></a> EventWinter2017FieldNumber

```csharp
public const int EventWinter2017FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventFall2016"></a> EventFall2016

```csharp
public CMsgGCToClientBattlePassRollup_Fall2016 EventFall2016 { get; set; }
```

#### Property Value

 [CMsgGCToClientBattlePassRollup\_Fall2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi10"></a> EventTi10

```csharp
public CMsgGCToClientBattlePassRollup_TI10 EventTi10 { get; set; }
```

#### Property Value

 [CMsgGCToClientBattlePassRollup\_TI10](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI10.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi6"></a> EventTi6

```csharp
public CMsgGCToClientBattlePassRollup_International2016 EventTi6 { get; set; }
```

#### Property Value

 [CMsgGCToClientBattlePassRollup\_International2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi7"></a> EventTi7

```csharp
public CMsgGCToClientBattlePassRollup_TI7 EventTi7 { get; set; }
```

#### Property Value

 [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi8"></a> EventTi8

```csharp
public CMsgGCToClientBattlePassRollup_TI8 EventTi8 { get; set; }
```

#### Property Value

 [CMsgGCToClientBattlePassRollup\_TI8](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventTi9"></a> EventTi9

```csharp
public CMsgGCToClientBattlePassRollup_TI9 EventTi9 { get; set; }
```

#### Property Value

 [CMsgGCToClientBattlePassRollup\_TI9](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI9.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_EventWinter2017"></a> EventWinter2017

```csharp
public CMsgGCToClientBattlePassRollup_Winter2017 EventWinter2017 { get; set; }
```

#### Property Value

 [CMsgGCToClientBattlePassRollup\_Winter2017](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Winter2017.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollupResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollupResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollupResponse Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollupResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_"></a> Equals\(CMsgGCToClientBattlePassRollupResponse\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollupResponse other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_"></a> MergeFrom\(CMsgGCToClientBattlePassRollupResponse\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollupResponse other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

