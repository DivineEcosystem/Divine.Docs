# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData"></a> Class CMsgDOTAClaimEventActionData.Types.GrantItemGiftData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimEventActionData.Types.GrantItemGiftData : IMessage<CMsgDOTAClaimEventActionData.Types.GrantItemGiftData>, IEquatable<CMsgDOTAClaimEventActionData.Types.GrantItemGiftData>, IDeepCloneable<CMsgDOTAClaimEventActionData.Types.GrantItemGiftData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimEventActionData.Types.GrantItemGiftData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.GrantItemGiftData.md)

#### Implements

IMessage<CMsgDOTAClaimEventActionData.Types.GrantItemGiftData\>, 
[IEquatable<CMsgDOTAClaimEventActionData.Types.GrantItemGiftData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimEventActionData.Types.GrantItemGiftData\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimEventActionData.Types.GrantItemGiftData\>\(CMsgDOTAClaimEventActionData.Types.GrantItemGiftData, params CMsgDOTAClaimEventActionData.Types.GrantItemGiftData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData__ctor"></a> GrantItemGiftData\(\)

```csharp
public GrantItemGiftData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_"></a> GrantItemGiftData\(GrantItemGiftData\)

```csharp
public GrantItemGiftData(CMsgDOTAClaimEventActionData.Types.GrantItemGiftData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.md).[GrantItemGiftData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.GrantItemGiftData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_GiftMessageFieldNumber"></a> GiftMessageFieldNumber

```csharp
public const int GiftMessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_GiveToAccountIdFieldNumber"></a> GiveToAccountIdFieldNumber

```csharp
public const int GiveToAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_GiftMessage"></a> GiftMessage

```csharp
public string GiftMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_GiveToAccountId"></a> GiveToAccountId

```csharp
public uint GiveToAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_HasGiftMessage"></a> HasGiftMessage

```csharp
public bool HasGiftMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_HasGiveToAccountId"></a> HasGiveToAccountId

```csharp
public bool HasGiveToAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimEventActionData.Types.GrantItemGiftData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.md).[GrantItemGiftData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.GrantItemGiftData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_ClearGiftMessage"></a> ClearGiftMessage\(\)

```csharp
public void ClearGiftMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_ClearGiveToAccountId"></a> ClearGiveToAccountId\(\)

```csharp
public void ClearGiveToAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimEventActionData.Types.GrantItemGiftData Clone()
```

#### Returns

 [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.md).[GrantItemGiftData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.GrantItemGiftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_"></a> Equals\(GrantItemGiftData\)

```csharp
public bool Equals(CMsgDOTAClaimEventActionData.Types.GrantItemGiftData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.md).[GrantItemGiftData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.GrantItemGiftData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_"></a> MergeFrom\(GrantItemGiftData\)

```csharp
public void MergeFrom(CMsgDOTAClaimEventActionData.Types.GrantItemGiftData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.md).[GrantItemGiftData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.GrantItemGiftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Types_GrantItemGiftData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

