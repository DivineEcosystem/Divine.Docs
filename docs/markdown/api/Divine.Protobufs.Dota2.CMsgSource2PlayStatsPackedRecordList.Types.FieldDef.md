# <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef"></a> Class CMsgSource2PlayStatsPackedRecordList.Types.FieldDef

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource2PlayStatsPackedRecordList.Types.FieldDef : IMessage<CMsgSource2PlayStatsPackedRecordList.Types.FieldDef>, IEquatable<CMsgSource2PlayStatsPackedRecordList.Types.FieldDef>, IDeepCloneable<CMsgSource2PlayStatsPackedRecordList.Types.FieldDef>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource2PlayStatsPackedRecordList.Types.FieldDef](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.FieldDef.md)

#### Implements

IMessage<CMsgSource2PlayStatsPackedRecordList.Types.FieldDef\>, 
[IEquatable<CMsgSource2PlayStatsPackedRecordList.Types.FieldDef\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource2PlayStatsPackedRecordList.Types.FieldDef\>, 
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
[EnumerableExtensions.In<CMsgSource2PlayStatsPackedRecordList.Types.FieldDef\>\(CMsgSource2PlayStatsPackedRecordList.Types.FieldDef, params CMsgSource2PlayStatsPackedRecordList.Types.FieldDef\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef__ctor"></a> FieldDef\(\)

```csharp
public FieldDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef__ctor_Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_"></a> FieldDef\(FieldDef\)

```csharp
public FieldDef(CMsgSource2PlayStatsPackedRecordList.Types.FieldDef other)
```

#### Parameters

`other` [CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[FieldDef](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.FieldDef.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_FieldNameFieldNumber"></a> FieldNameFieldNumber

```csharp
public const int FieldNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_FieldTypeFieldNumber"></a> FieldTypeFieldNumber

```csharp
public const int FieldTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_FieldName"></a> FieldName

```csharp
public string FieldName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_FieldType"></a> FieldType

```csharp
public ESource2PlayStatsFieldType FieldType { get; set; }
```

#### Property Value

 [ESource2PlayStatsFieldType](Divine.Protobufs.Dota2.ESource2PlayStatsFieldType.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_HasFieldName"></a> HasFieldName

```csharp
public bool HasFieldName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_HasFieldType"></a> HasFieldType

```csharp
public bool HasFieldType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource2PlayStatsPackedRecordList.Types.FieldDef> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[FieldDef](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.FieldDef.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_ClearFieldName"></a> ClearFieldName\(\)

```csharp
public void ClearFieldName()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_ClearFieldType"></a> ClearFieldType\(\)

```csharp
public void ClearFieldType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_Clone"></a> Clone\(\)

```csharp
public CMsgSource2PlayStatsPackedRecordList.Types.FieldDef Clone()
```

#### Returns

 [CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[FieldDef](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.FieldDef.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_Equals_Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_"></a> Equals\(FieldDef\)

```csharp
public bool Equals(CMsgSource2PlayStatsPackedRecordList.Types.FieldDef other)
```

#### Parameters

`other` [CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[FieldDef](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.FieldDef.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_MergeFrom_Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_"></a> MergeFrom\(FieldDef\)

```csharp
public void MergeFrom(CMsgSource2PlayStatsPackedRecordList.Types.FieldDef other)
```

#### Parameters

`other` [CMsgSource2PlayStatsPackedRecordList](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.md).[Types](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.md).[FieldDef](Divine.Protobufs.Dota2.CMsgSource2PlayStatsPackedRecordList.Types.FieldDef.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource2PlayStatsPackedRecordList_Types_FieldDef_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

