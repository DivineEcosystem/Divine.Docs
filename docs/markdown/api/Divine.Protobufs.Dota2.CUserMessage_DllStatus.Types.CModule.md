# <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule"></a> Class CUserMessage\_DllStatus.Types.CModule

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_DllStatus.Types.CModule : IMessage<CUserMessage_DllStatus.Types.CModule>, IEquatable<CUserMessage_DllStatus.Types.CModule>, IDeepCloneable<CUserMessage_DllStatus.Types.CModule>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_DllStatus.Types.CModule](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CModule.md)

#### Implements

IMessage<CUserMessage\_DllStatus.Types.CModule\>, 
[IEquatable<CUserMessage\_DllStatus.Types.CModule\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_DllStatus.Types.CModule\>, 
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
[EnumerableExtensions.In<CUserMessage\_DllStatus.Types.CModule\>\(CUserMessage\_DllStatus.Types.CModule, params CUserMessage\_DllStatus.Types.CModule\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule__ctor"></a> CModule\(\)

```csharp
public CModule()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule__ctor_Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_"></a> CModule\(CModule\)

```csharp
public CModule(CUserMessage_DllStatus.Types.CModule other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CModule](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CModule.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_BaseAddrFieldNumber"></a> BaseAddrFieldNumber

```csharp
public const int BaseAddrFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_SizeFieldNumber"></a> SizeFieldNumber

```csharp
public const int SizeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_BaseAddr"></a> BaseAddr

```csharp
public ulong BaseAddr { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_HasBaseAddr"></a> HasBaseAddr

```csharp
public bool HasBaseAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_HasSize"></a> HasSize

```csharp
public bool HasSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_DllStatus.Types.CModule> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CModule](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CModule.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_Size"></a> Size

```csharp
public uint Size { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_ClearBaseAddr"></a> ClearBaseAddr\(\)

```csharp
public void ClearBaseAddr()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_ClearSize"></a> ClearSize\(\)

```csharp
public void ClearSize()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_Clone"></a> Clone\(\)

```csharp
public CUserMessage_DllStatus.Types.CModule Clone()
```

#### Returns

 [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CModule](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CModule.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_Equals_Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_"></a> Equals\(CModule\)

```csharp
public bool Equals(CUserMessage_DllStatus.Types.CModule other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CModule](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CModule.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_"></a> MergeFrom\(CModule\)

```csharp
public void MergeFrom(CUserMessage_DllStatus.Types.CModule other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CModule](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CModule.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CModule_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

