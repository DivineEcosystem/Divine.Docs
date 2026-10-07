# <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample"></a> Class CMsgFightingGame\_GameData\_Fighting.Types.InputSample

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgFightingGame_GameData_Fighting.Types.InputSample : IMessage<CMsgFightingGame_GameData_Fighting.Types.InputSample>, IEquatable<CMsgFightingGame_GameData_Fighting.Types.InputSample>, IDeepCloneable<CMsgFightingGame_GameData_Fighting.Types.InputSample>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgFightingGame\_GameData\_Fighting.Types.InputSample](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.InputSample.md)

#### Implements

IMessage<CMsgFightingGame\_GameData\_Fighting.Types.InputSample\>, 
[IEquatable<CMsgFightingGame\_GameData\_Fighting.Types.InputSample\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgFightingGame\_GameData\_Fighting.Types.InputSample\>, 
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
[EnumerableExtensions.In<CMsgFightingGame\_GameData\_Fighting.Types.InputSample\>\(CMsgFightingGame\_GameData\_Fighting.Types.InputSample, params CMsgFightingGame\_GameData\_Fighting.Types.InputSample\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample__ctor"></a> InputSample\(\)

```csharp
public InputSample()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample__ctor_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_"></a> InputSample\(InputSample\)

```csharp
public InputSample(CMsgFightingGame_GameData_Fighting.Types.InputSample other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.md).[InputSample](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.InputSample.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_ButtonMaskFieldNumber"></a> ButtonMaskFieldNumber

```csharp
public const int ButtonMaskFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_ButtonMask"></a> ButtonMask

```csharp
public uint ButtonMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_HasButtonMask"></a> HasButtonMask

```csharp
public bool HasButtonMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_Parser"></a> Parser

```csharp
public static MessageParser<CMsgFightingGame_GameData_Fighting.Types.InputSample> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.md).[InputSample](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.InputSample.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_ClearButtonMask"></a> ClearButtonMask\(\)

```csharp
public void ClearButtonMask()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_Clone"></a> Clone\(\)

```csharp
public CMsgFightingGame_GameData_Fighting.Types.InputSample Clone()
```

#### Returns

 [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.md).[InputSample](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.InputSample.md)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_Equals_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_"></a> Equals\(InputSample\)

```csharp
public bool Equals(CMsgFightingGame_GameData_Fighting.Types.InputSample other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.md).[InputSample](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.InputSample.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_MergeFrom_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_"></a> MergeFrom\(InputSample\)

```csharp
public void MergeFrom(CMsgFightingGame_GameData_Fighting.Types.InputSample other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.md).[InputSample](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.InputSample.md)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Types_InputSample_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

