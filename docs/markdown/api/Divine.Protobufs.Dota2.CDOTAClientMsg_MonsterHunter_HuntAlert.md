# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert"></a> Class CDOTAClientMsg\_MonsterHunter\_HuntAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_MonsterHunter_HuntAlert : IMessage<CDOTAClientMsg_MonsterHunter_HuntAlert>, IEquatable<CDOTAClientMsg_MonsterHunter_HuntAlert>, IDeepCloneable<CDOTAClientMsg_MonsterHunter_HuntAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_HuntAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_MonsterHunter\_HuntAlert\>, 
[IEquatable<CDOTAClientMsg\_MonsterHunter\_HuntAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_MonsterHunter\_HuntAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_MonsterHunter\_HuntAlert\>\(CDOTAClientMsg\_MonsterHunter\_HuntAlert, params CDOTAClientMsg\_MonsterHunter\_HuntAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert__ctor"></a> CDOTAClientMsg\_MonsterHunter\_HuntAlert\(\)

```csharp
public CDOTAClientMsg_MonsterHunter_HuntAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_"></a> CDOTAClientMsg\_MonsterHunter\_HuntAlert\(CDOTAClientMsg\_MonsterHunter\_HuntAlert\)

```csharp
public CDOTAClientMsg_MonsterHunter_HuntAlert(CDOTAClientMsg_MonsterHunter_HuntAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_HuntAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_CtrlPressedFieldNumber"></a> CtrlPressedFieldNumber

```csharp
public const int CtrlPressedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_InvestigationStateIndexFieldNumber"></a> InvestigationStateIndexFieldNumber

```csharp
public const int InvestigationStateIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_CtrlPressed"></a> CtrlPressed

```csharp
public bool CtrlPressed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_HasCtrlPressed"></a> HasCtrlPressed

```csharp
public bool HasCtrlPressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_HasInvestigationStateIndex"></a> HasInvestigationStateIndex

```csharp
public bool HasInvestigationStateIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_InvestigationStateIndex"></a> InvestigationStateIndex

```csharp
public uint InvestigationStateIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_MonsterHunter_HuntAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_HuntAlert.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_ClearCtrlPressed"></a> ClearCtrlPressed\(\)

```csharp
public void ClearCtrlPressed()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_ClearInvestigationStateIndex"></a> ClearInvestigationStateIndex\(\)

```csharp
public void ClearInvestigationStateIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_MonsterHunter_HuntAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_HuntAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_"></a> Equals\(CDOTAClientMsg\_MonsterHunter\_HuntAlert\)

```csharp
public bool Equals(CDOTAClientMsg_MonsterHunter_HuntAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_HuntAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_"></a> MergeFrom\(CDOTAClientMsg\_MonsterHunter\_HuntAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_MonsterHunter_HuntAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_HuntAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_HuntAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

