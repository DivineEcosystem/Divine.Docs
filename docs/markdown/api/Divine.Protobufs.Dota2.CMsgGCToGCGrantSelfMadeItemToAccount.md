# <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount"></a> Class CMsgGCToGCGrantSelfMadeItemToAccount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCGrantSelfMadeItemToAccount : IMessage<CMsgGCToGCGrantSelfMadeItemToAccount>, IEquatable<CMsgGCToGCGrantSelfMadeItemToAccount>, IDeepCloneable<CMsgGCToGCGrantSelfMadeItemToAccount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCGrantSelfMadeItemToAccount](Divine.Protobufs.Dota2.CMsgGCToGCGrantSelfMadeItemToAccount.md)

#### Implements

IMessage<CMsgGCToGCGrantSelfMadeItemToAccount\>, 
[IEquatable<CMsgGCToGCGrantSelfMadeItemToAccount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCGrantSelfMadeItemToAccount\>, 
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
[EnumerableExtensions.In<CMsgGCToGCGrantSelfMadeItemToAccount\>\(CMsgGCToGCGrantSelfMadeItemToAccount, params CMsgGCToGCGrantSelfMadeItemToAccount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount__ctor"></a> CMsgGCToGCGrantSelfMadeItemToAccount\(\)

```csharp
public CMsgGCToGCGrantSelfMadeItemToAccount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount__ctor_Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_"></a> CMsgGCToGCGrantSelfMadeItemToAccount\(CMsgGCToGCGrantSelfMadeItemToAccount\)

```csharp
public CMsgGCToGCGrantSelfMadeItemToAccount(CMsgGCToGCGrantSelfMadeItemToAccount other)
```

#### Parameters

`other` [CMsgGCToGCGrantSelfMadeItemToAccount](Divine.Protobufs.Dota2.CMsgGCToGCGrantSelfMadeItemToAccount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_AccountidFieldNumber"></a> AccountidFieldNumber

```csharp
public const int AccountidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_ItemDefIndexFieldNumber"></a> ItemDefIndexFieldNumber

```csharp
public const int ItemDefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_Accountid"></a> Accountid

```csharp
public uint Accountid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_HasAccountid"></a> HasAccountid

```csharp
public bool HasAccountid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_HasItemDefIndex"></a> HasItemDefIndex

```csharp
public bool HasItemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_ItemDefIndex"></a> ItemDefIndex

```csharp
public uint ItemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCGrantSelfMadeItemToAccount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCGrantSelfMadeItemToAccount](Divine.Protobufs.Dota2.CMsgGCToGCGrantSelfMadeItemToAccount.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_ClearAccountid"></a> ClearAccountid\(\)

```csharp
public void ClearAccountid()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_ClearItemDefIndex"></a> ClearItemDefIndex\(\)

```csharp
public void ClearItemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCGrantSelfMadeItemToAccount Clone()
```

#### Returns

 [CMsgGCToGCGrantSelfMadeItemToAccount](Divine.Protobufs.Dota2.CMsgGCToGCGrantSelfMadeItemToAccount.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_Equals_Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_"></a> Equals\(CMsgGCToGCGrantSelfMadeItemToAccount\)

```csharp
public bool Equals(CMsgGCToGCGrantSelfMadeItemToAccount other)
```

#### Parameters

`other` [CMsgGCToGCGrantSelfMadeItemToAccount](Divine.Protobufs.Dota2.CMsgGCToGCGrantSelfMadeItemToAccount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_"></a> MergeFrom\(CMsgGCToGCGrantSelfMadeItemToAccount\)

```csharp
public void MergeFrom(CMsgGCToGCGrantSelfMadeItemToAccount other)
```

#### Parameters

`other` [CMsgGCToGCGrantSelfMadeItemToAccount](Divine.Protobufs.Dota2.CMsgGCToGCGrantSelfMadeItemToAccount.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGrantSelfMadeItemToAccount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

