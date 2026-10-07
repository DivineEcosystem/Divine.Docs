# <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange"></a> Class CMsgDOTANotifyAccountFlagsChange

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTANotifyAccountFlagsChange : IMessage<CMsgDOTANotifyAccountFlagsChange>, IEquatable<CMsgDOTANotifyAccountFlagsChange>, IDeepCloneable<CMsgDOTANotifyAccountFlagsChange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTANotifyAccountFlagsChange](Divine.Protobufs.Dota2.CMsgDOTANotifyAccountFlagsChange.md)

#### Implements

IMessage<CMsgDOTANotifyAccountFlagsChange\>, 
[IEquatable<CMsgDOTANotifyAccountFlagsChange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTANotifyAccountFlagsChange\>, 
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
[EnumerableExtensions.In<CMsgDOTANotifyAccountFlagsChange\>\(CMsgDOTANotifyAccountFlagsChange, params CMsgDOTANotifyAccountFlagsChange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange__ctor"></a> CMsgDOTANotifyAccountFlagsChange\(\)

```csharp
public CMsgDOTANotifyAccountFlagsChange()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange__ctor_Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_"></a> CMsgDOTANotifyAccountFlagsChange\(CMsgDOTANotifyAccountFlagsChange\)

```csharp
public CMsgDOTANotifyAccountFlagsChange(CMsgDOTANotifyAccountFlagsChange other)
```

#### Parameters

`other` [CMsgDOTANotifyAccountFlagsChange](Divine.Protobufs.Dota2.CMsgDOTANotifyAccountFlagsChange.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_AccountFlagsFieldNumber"></a> AccountFlagsFieldNumber

```csharp
public const int AccountFlagsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_AccountidFieldNumber"></a> AccountidFieldNumber

```csharp
public const int AccountidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_AccountFlags"></a> AccountFlags

```csharp
public uint AccountFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_Accountid"></a> Accountid

```csharp
public uint Accountid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_HasAccountFlags"></a> HasAccountFlags

```csharp
public bool HasAccountFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_HasAccountid"></a> HasAccountid

```csharp
public bool HasAccountid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTANotifyAccountFlagsChange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTANotifyAccountFlagsChange](Divine.Protobufs.Dota2.CMsgDOTANotifyAccountFlagsChange.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_ClearAccountFlags"></a> ClearAccountFlags\(\)

```csharp
public void ClearAccountFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_ClearAccountid"></a> ClearAccountid\(\)

```csharp
public void ClearAccountid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_Clone"></a> Clone\(\)

```csharp
public CMsgDOTANotifyAccountFlagsChange Clone()
```

#### Returns

 [CMsgDOTANotifyAccountFlagsChange](Divine.Protobufs.Dota2.CMsgDOTANotifyAccountFlagsChange.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_Equals_Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_"></a> Equals\(CMsgDOTANotifyAccountFlagsChange\)

```csharp
public bool Equals(CMsgDOTANotifyAccountFlagsChange other)
```

#### Parameters

`other` [CMsgDOTANotifyAccountFlagsChange](Divine.Protobufs.Dota2.CMsgDOTANotifyAccountFlagsChange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_"></a> MergeFrom\(CMsgDOTANotifyAccountFlagsChange\)

```csharp
public void MergeFrom(CMsgDOTANotifyAccountFlagsChange other)
```

#### Parameters

`other` [CMsgDOTANotifyAccountFlagsChange](Divine.Protobufs.Dota2.CMsgDOTANotifyAccountFlagsChange.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTANotifyAccountFlagsChange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

