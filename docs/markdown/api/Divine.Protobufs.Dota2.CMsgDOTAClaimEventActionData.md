# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData"></a> Class CMsgDOTAClaimEventActionData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimEventActionData : IMessage<CMsgDOTAClaimEventActionData>, IEquatable<CMsgDOTAClaimEventActionData>, IDeepCloneable<CMsgDOTAClaimEventActionData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md)

#### Implements

IMessage<CMsgDOTAClaimEventActionData\>, 
[IEquatable<CMsgDOTAClaimEventActionData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimEventActionData\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimEventActionData\>\(CMsgDOTAClaimEventActionData, params CMsgDOTAClaimEventActionData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData__ctor"></a> CMsgDOTAClaimEventActionData\(\)

```csharp
public CMsgDOTAClaimEventActionData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_"></a> CMsgDOTAClaimEventActionData\(CMsgDOTAClaimEventActionData\)

```csharp
public CMsgDOTAClaimEventActionData(CMsgDOTAClaimEventActionData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_GrantItemChoiceItemDefFieldNumber"></a> GrantItemChoiceItemDefFieldNumber

```csharp
public const int GrantItemChoiceItemDefFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_GrantItemGiftDataFieldNumber"></a> GrantItemGiftDataFieldNumber

```csharp
public const int GrantItemGiftDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_GrantItemChoiceItemDef"></a> GrantItemChoiceItemDef

```csharp
public ulong GrantItemChoiceItemDef { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_GrantItemGiftData"></a> GrantItemGiftData

```csharp
public CMsgDOTAClaimEventActionData.Types.GrantItemGiftData GrantItemGiftData { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.md).[GrantItemGiftData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.Types.GrantItemGiftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_HasGrantItemChoiceItemDef"></a> HasGrantItemChoiceItemDef

```csharp
public bool HasGrantItemChoiceItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimEventActionData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_ClearGrantItemChoiceItemDef"></a> ClearGrantItemChoiceItemDef\(\)

```csharp
public void ClearGrantItemChoiceItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimEventActionData Clone()
```

#### Returns

 [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_"></a> Equals\(CMsgDOTAClaimEventActionData\)

```csharp
public bool Equals(CMsgDOTAClaimEventActionData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_"></a> MergeFrom\(CMsgDOTAClaimEventActionData\)

```csharp
public void MergeFrom(CMsgDOTAClaimEventActionData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

