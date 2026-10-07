# <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum"></a> Class CMvpData.Types.MvpDatum

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMvpData.Types.MvpDatum : IMessage<CMvpData.Types.MvpDatum>, IEquatable<CMvpData.Types.MvpDatum>, IDeepCloneable<CMvpData.Types.MvpDatum>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMvpData.Types.MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md)

#### Implements

IMessage<CMvpData.Types.MvpDatum\>, 
[IEquatable<CMvpData.Types.MvpDatum\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMvpData.Types.MvpDatum\>, 
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
[EnumerableExtensions.In<CMvpData.Types.MvpDatum\>\(CMvpData.Types.MvpDatum, params CMvpData.Types.MvpDatum\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum__ctor"></a> MvpDatum\(\)

```csharp
public MvpDatum()
```

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum__ctor_Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_"></a> MvpDatum\(MvpDatum\)

```csharp
public MvpDatum(CMvpData.Types.MvpDatum other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_AccoladesFieldNumber"></a> AccoladesFieldNumber

```csharp
public const int AccoladesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Accolades"></a> Accolades

```csharp
public RepeatedField<CMvpData.Types.MvpDatum.Types.MvpAccolade> Accolades { get; }
```

#### Property Value

 RepeatedField<[CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.md).[MvpAccolade](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.md)\>

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Parser"></a> Parser

```csharp
public static MessageParser<CMvpData.Types.MvpDatum> Parser { get; }
```

#### Property Value

 MessageParser<[CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md)\>

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_PlayerSlot"></a> PlayerSlot

```csharp
public uint PlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Clone"></a> Clone\(\)

```csharp
public CMvpData.Types.MvpDatum Clone()
```

#### Returns

 [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Equals_Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_"></a> Equals\(MvpDatum\)

```csharp
public bool Equals(CMvpData.Types.MvpDatum other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_MergeFrom_Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_"></a> MergeFrom\(MvpDatum\)

```csharp
public void MergeFrom(CMvpData.Types.MvpDatum other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

