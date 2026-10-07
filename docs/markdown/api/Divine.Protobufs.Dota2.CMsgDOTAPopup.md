# <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup"></a> Class CMsgDOTAPopup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPopup : IMessage<CMsgDOTAPopup>, IEquatable<CMsgDOTAPopup>, IDeepCloneable<CMsgDOTAPopup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPopup](Divine.Protobufs.Dota2.CMsgDOTAPopup.md)

#### Implements

IMessage<CMsgDOTAPopup\>, 
[IEquatable<CMsgDOTAPopup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPopup\>, 
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
[EnumerableExtensions.In<CMsgDOTAPopup\>\(CMsgDOTAPopup, params CMsgDOTAPopup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup__ctor"></a> CMsgDOTAPopup\(\)

```csharp
public CMsgDOTAPopup()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup__ctor_Divine_Protobufs_Dota2_CMsgDOTAPopup_"></a> CMsgDOTAPopup\(CMsgDOTAPopup\)

```csharp
public CMsgDOTAPopup(CMsgDOTAPopup other)
```

#### Parameters

`other` [CMsgDOTAPopup](Divine.Protobufs.Dota2.CMsgDOTAPopup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_CustomTextFieldNumber"></a> CustomTextFieldNumber

```csharp
public const int CustomTextFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_DebugTextFieldNumber"></a> DebugTextFieldNumber

```csharp
public const int DebugTextFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_IntDataFieldNumber"></a> IntDataFieldNumber

```csharp
public const int IntDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_LocTokenHeaderFieldNumber"></a> LocTokenHeaderFieldNumber

```csharp
public const int LocTokenHeaderFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_LocTokenMsgFieldNumber"></a> LocTokenMsgFieldNumber

```csharp
public const int LocTokenMsgFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_PopupDataFieldNumber"></a> PopupDataFieldNumber

```csharp
public const int PopupDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_VarNamesFieldNumber"></a> VarNamesFieldNumber

```csharp
public const int VarNamesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_VarValuesFieldNumber"></a> VarValuesFieldNumber

```csharp
public const int VarValuesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_CustomText"></a> CustomText

```csharp
public string CustomText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_DebugText"></a> DebugText

```csharp
public string DebugText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_HasCustomText"></a> HasCustomText

```csharp
public bool HasCustomText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_HasDebugText"></a> HasDebugText

```csharp
public bool HasDebugText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_HasIntData"></a> HasIntData

```csharp
public bool HasIntData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_HasLocTokenHeader"></a> HasLocTokenHeader

```csharp
public bool HasLocTokenHeader { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_HasLocTokenMsg"></a> HasLocTokenMsg

```csharp
public bool HasLocTokenMsg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_HasPopupData"></a> HasPopupData

```csharp
public bool HasPopupData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_Id"></a> Id

```csharp
public CMsgDOTAPopup.Types.PopupID Id { get; set; }
```

#### Property Value

 [CMsgDOTAPopup](Divine.Protobufs.Dota2.CMsgDOTAPopup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPopup.Types.md).[PopupID](Divine.Protobufs.Dota2.CMsgDOTAPopup.Types.PopupID.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_IntData"></a> IntData

```csharp
public int IntData { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_LocTokenHeader"></a> LocTokenHeader

```csharp
public string LocTokenHeader { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_LocTokenMsg"></a> LocTokenMsg

```csharp
public string LocTokenMsg { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPopup> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPopup](Divine.Protobufs.Dota2.CMsgDOTAPopup.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_PopupData"></a> PopupData

```csharp
public ByteString PopupData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_VarNames"></a> VarNames

```csharp
public RepeatedField<string> VarNames { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_VarValues"></a> VarValues

```csharp
public RepeatedField<string> VarValues { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_ClearCustomText"></a> ClearCustomText\(\)

```csharp
public void ClearCustomText()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_ClearDebugText"></a> ClearDebugText\(\)

```csharp
public void ClearDebugText()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_ClearIntData"></a> ClearIntData\(\)

```csharp
public void ClearIntData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_ClearLocTokenHeader"></a> ClearLocTokenHeader\(\)

```csharp
public void ClearLocTokenHeader()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_ClearLocTokenMsg"></a> ClearLocTokenMsg\(\)

```csharp
public void ClearLocTokenMsg()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_ClearPopupData"></a> ClearPopupData\(\)

```csharp
public void ClearPopupData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPopup Clone()
```

#### Returns

 [CMsgDOTAPopup](Divine.Protobufs.Dota2.CMsgDOTAPopup.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_Equals_Divine_Protobufs_Dota2_CMsgDOTAPopup_"></a> Equals\(CMsgDOTAPopup\)

```csharp
public bool Equals(CMsgDOTAPopup other)
```

#### Parameters

`other` [CMsgDOTAPopup](Divine.Protobufs.Dota2.CMsgDOTAPopup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPopup_"></a> MergeFrom\(CMsgDOTAPopup\)

```csharp
public void MergeFrom(CMsgDOTAPopup other)
```

#### Parameters

`other` [CMsgDOTAPopup](Divine.Protobufs.Dota2.CMsgDOTAPopup.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPopup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

