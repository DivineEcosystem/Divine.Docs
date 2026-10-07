# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode"></a> Class CDOTAClientMsg\_UnitsAutoAttackMode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_UnitsAutoAttackMode : IMessage<CDOTAClientMsg_UnitsAutoAttackMode>, IEquatable<CDOTAClientMsg_UnitsAutoAttackMode>, IDeepCloneable<CDOTAClientMsg_UnitsAutoAttackMode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_UnitsAutoAttackMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.md)

#### Implements

IMessage<CDOTAClientMsg\_UnitsAutoAttackMode\>, 
[IEquatable<CDOTAClientMsg\_UnitsAutoAttackMode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_UnitsAutoAttackMode\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_UnitsAutoAttackMode\>\(CDOTAClientMsg\_UnitsAutoAttackMode, params CDOTAClientMsg\_UnitsAutoAttackMode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode__ctor"></a> CDOTAClientMsg\_UnitsAutoAttackMode\(\)

```csharp
public CDOTAClientMsg_UnitsAutoAttackMode()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_"></a> CDOTAClientMsg\_UnitsAutoAttackMode\(CDOTAClientMsg\_UnitsAutoAttackMode\)

```csharp
public CDOTAClientMsg_UnitsAutoAttackMode(CDOTAClientMsg_UnitsAutoAttackMode other)
```

#### Parameters

`other` [CDOTAClientMsg\_UnitsAutoAttackMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_ModeFieldNumber"></a> ModeFieldNumber

```csharp
public const int ModeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_UnitTypeFieldNumber"></a> UnitTypeFieldNumber

```csharp
public const int UnitTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_HasMode"></a> HasMode

```csharp
public bool HasMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_HasUnitType"></a> HasUnitType

```csharp
public bool HasUnitType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_Mode"></a> Mode

```csharp
public CDOTAClientMsg_UnitsAutoAttackMode.Types.EMode Mode { get; set; }
```

#### Property Value

 [CDOTAClientMsg\_UnitsAutoAttackMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.Types.md).[EMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.Types.EMode.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_UnitsAutoAttackMode> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_UnitsAutoAttackMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_UnitType"></a> UnitType

```csharp
public CDOTAClientMsg_UnitsAutoAttackMode.Types.EUnitType UnitType { get; set; }
```

#### Property Value

 [CDOTAClientMsg\_UnitsAutoAttackMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.Types.md).[EUnitType](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.Types.EUnitType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_ClearMode"></a> ClearMode\(\)

```csharp
public void ClearMode()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_ClearUnitType"></a> ClearUnitType\(\)

```csharp
public void ClearUnitType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_UnitsAutoAttackMode Clone()
```

#### Returns

 [CDOTAClientMsg\_UnitsAutoAttackMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_"></a> Equals\(CDOTAClientMsg\_UnitsAutoAttackMode\)

```csharp
public bool Equals(CDOTAClientMsg_UnitsAutoAttackMode other)
```

#### Parameters

`other` [CDOTAClientMsg\_UnitsAutoAttackMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_"></a> MergeFrom\(CDOTAClientMsg\_UnitsAutoAttackMode\)

```csharp
public void MergeFrom(CDOTAClientMsg_UnitsAutoAttackMode other)
```

#### Parameters

`other` [CDOTAClientMsg\_UnitsAutoAttackMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_UnitsAutoAttackMode.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UnitsAutoAttackMode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

