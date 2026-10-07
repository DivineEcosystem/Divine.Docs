# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData"></a> Class CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData : IMessage<CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData>, IEquatable<CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData>, IDeepCloneable<CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData.md)

#### Implements

IMessage<CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData\>, 
[IEquatable<CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData\>\(CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData, params CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData__ctor"></a> ActionListRewardData\(\)

```csharp
public ActionListRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_"></a> ActionListRewardData\(ActionListRewardData\)

```csharp
public ActionListRewardData(CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[ActionListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_ResultRewardDataFieldNumber"></a> ResultRewardDataFieldNumber

```csharp
public const int ResultRewardDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_HasResultRewardData"></a> HasResultRewardData

```csharp
public bool HasResultRewardData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[ActionListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_ResultRewardData"></a> ResultRewardData

```csharp
public ByteString ResultRewardData { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_ClearResultRewardData"></a> ClearResultRewardData\(\)

```csharp
public void ClearResultRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData Clone()
```

#### Returns

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[ActionListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_"></a> Equals\(ActionListRewardData\)

```csharp
public bool Equals(CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[ActionListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_"></a> MergeFrom\(ActionListRewardData\)

```csharp
public void MergeFrom(CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[ActionListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.ActionListRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_ActionListRewardData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

